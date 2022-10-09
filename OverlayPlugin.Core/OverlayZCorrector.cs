using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RainbowMage.OverlayPlugin
{
    class OverlayZCorrector
    {
        private PluginMain main;
        private ILogger logger;
        private Timer timer;
        private FFXIVRepository repository;
        private Process xivProc;

        public OverlayZCorrector(TinyIoCContainer container)
        {
            main = container.Resolve<PluginMain>();
            logger = container.Resolve<ILogger>();
            repository = container.Resolve<FFXIVRepository>();

            var span = TimeSpan.FromSeconds(3);
            timer = new Timer(EnsureOverlaysAreOverGame, null, span, span);

            repository.RegisterProcessChangedHandler(UpdateFFXIVProcess);
        }

        public void DeInit()
        {
            timer.Change(0, -1);
        }

        private void UpdateFFXIVProcess(Process p)
        {
            xivProc = p;
        }

        private void EnsureOverlaysAreOverGame(object _)
        {
            var watch = new Stopwatch();
            watch.Start();

            if (xivProc == null || xivProc.HasExited)
                return;

            var xivHandle = xivProc.MainWindowHandle;
            var overlayWindows = new List<IntPtr>();

            var handle = xivHandle;
            while (handle != IntPtr.Zero)
            {
                handle = NativeMethods.GetWindow(handle, NativeMethods.GW_HWNDPREV);
                overlayWindows.Add(handle);
            }

            foreach (var overlay in main.Overlays)
            {
                if (!overlayWindows.Contains(overlay.Handle))
                {
                    // The overlay is behind the game. Let's fix that.
                    NativeMethods.SetWindowPos(
                        overlay.Handle,
                        NativeMethods.HWND_TOPMOST,
                        0, 0, 0, 0,
                        NativeMethods.SWP_NOSIZE | NativeMethods.SWP_NOMOVE | NativeMethods.SWP_NOACTIVATE);

                    logger.Log(LogLevel.Info, $"ZReorder: Fixed {overlay.Name}.");
                }
            }

            // logger.Log(LogLevel.Debug, $"ZReorder: Took {watch.Elapsed.TotalSeconds}s.");
        }
    }
}
