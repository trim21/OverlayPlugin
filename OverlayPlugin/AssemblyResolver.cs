using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowMage.OverlayPlugin
{
    class AssemblyResolver : IDisposable
    {
        static readonly Regex assemblyNameParser = new Regex(
            @"(?<name>.+?), Version=(?<version>.+?), Culture=(?<culture>.+?), PublicKeyToken=(?<pubkey>.+)",
            RegexOptions.Compiled);
        static readonly List<string> OverlayPluginFiles = new List<string> {
            "OverlayPlugin.Common", "OverlayPlugin.Core", "OverlayPlugin.Updater", "HtmlRenderer"
        };

        public List<string> Directories { get; set; }
        private Dictionary<string, Assembly> assemblyCache = new Dictionary<string, Assembly>();

        public AssemblyResolver(IEnumerable<string> directories)
        {
            this.Directories = new List<string>();
            if (directories != null)
            {
                this.Directories.AddRange(directories);
            }

            AppDomain.CurrentDomain.AssemblyResolve += CustomAssemblyResolve;
        }

        public AssemblyResolver()
            : this(null)
        {

        }

        public void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyResolve -= CustomAssemblyResolve;
        }

        private Assembly CustomAssemblyResolve(object sender, ResolveEventArgs e)
        {
            Assembly result;
            if (assemblyCache.TryGetValue(e.Name, out result))
            {
                return result;
            }

            var match = assemblyNameParser.Match(e.Name);

            if (assemblyCache.TryGetValue(match.Groups["name"].Value, out result))
            {
                return result;
            }

            // Directories プロパティで指定されたディレクトリを基準にアセンブリを検索する
            foreach (var directory in this.Directories)
            {
                var asmPath = "";

                if (match.Success)
                {
                    var asmFileName = match.Groups["name"].Value + ".dll";
                    if (match.Groups["culture"].Value == "neutral")
                    {
                        asmPath = Path.Combine(directory, asmFileName);
                    }
                    else
                    {
                        asmPath = Path.Combine(directory, match.Groups["culture"].Value, asmFileName);
                    }
                }
                else
                {
                    asmPath = Path.Combine(directory, e.Name + ".dll");
                }

                if (File.Exists(asmPath))
                {
                    Assembly asm;
#if !DEBUG
                    if (e.Name.Contains("CefSharp"))
                    {
#endif
                        asm = Assembly.LoadFile(asmPath);
#if !DEBUG
                    }
                    else
                    {
                        asm = Assembly.Load(File.ReadAllBytes(asmPath));
                    }
#endif
                    OnAssemblyLoaded(asm);
                    assemblyCache[e.Name] = asm;

                    if (match.Success)
                    {
                        assemblyCache[match.Groups["name"].Value] = asm;
                    }
                    return asm;
                }
            }

            return null;
        }

        protected void OnExceptionOccured(Exception exception)
        {
            if (this.ExceptionOccured != null)
            {
                this.ExceptionOccured(this, new ExceptionOccuredEventArgs(exception));
            }
        }

        protected void OnAssemblyLoaded(Assembly assembly)
        {
            if (this.AssemblyLoaded != null)
            {
                this.AssemblyLoaded(this, new AssemblyLoadEventArgs(assembly));
            }
        }

        public event EventHandler<ExceptionOccuredEventArgs> ExceptionOccured;
        public event EventHandler<AssemblyLoadEventArgs> AssemblyLoaded;

        public class ExceptionOccuredEventArgs : EventArgs
        {
            public Exception Exception { get; set; }
            public ExceptionOccuredEventArgs(Exception exception)
            {
                this.Exception = exception;
            }
        }
    }
}
