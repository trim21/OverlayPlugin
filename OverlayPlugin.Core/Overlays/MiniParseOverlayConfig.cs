using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RainbowMage.OverlayPlugin.Overlays
{
    public class MiniParseOverlayConfig : OverlayConfigBase
    {
        public override Type OverlayType => typeof(MiniParseOverlay);

        public event EventHandler<CompatbilityChangedArgs> ActwsCompatibilityChanged;
        public event EventHandler NoFocusChanged;
        public event EventHandler ZoomChanged;
        public event EventHandler ForceWhiteBackgroundChanged;
        public event EventHandler MuteWhenHiddenChanged;

        private bool actwsCompatibility;
        public bool ActwsCompatibility
        {
            get
            {
                return this.actwsCompatibility;
            }
            set
            {
                this.actwsCompatibility = value;
                ActwsCompatibilityChanged?.Invoke(this, new CompatbilityChangedArgs(value));
            }
        }

        private bool noFocus;
        public bool NoFocus
        {
            get
            {
                return this.noFocus;
            }
            set
            {
                if (this.noFocus != value)
                {
                    this.noFocus = value;
                    NoFocusChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        private int zoom = 1;
        public int Zoom
        {
            get
            {
                return this.zoom;
            }
            set
            {
                if (this.zoom != value)
                {
                    this.zoom = value;
                    ZoomChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public bool forceWhiteBackground;
        public bool ForceWhiteBackground
        {
            get
            {
                return this.forceWhiteBackground;
            }
            set
            {
                if (this.forceWhiteBackground != value)
                {
                    this.forceWhiteBackground = value;
                    ForceWhiteBackgroundChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        private bool muteWhenHidden;
        public bool MuteWhenHidden
        {
            get
            {
                return muteWhenHidden;
            }
            set
            {
                if (muteWhenHidden != value)
                {
                    muteWhenHidden = value;
                    MuteWhenHiddenChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public MiniParseOverlayConfig(string name) : base(name)
        {
            this.noFocus = true;
            this.zoom = 0;
        }

        public MiniParseOverlayConfig() : base(null) { }

        public class CompatbilityChangedArgs : EventArgs
        {
            public bool Compatibility { get; private set; }

            public CompatbilityChangedArgs(bool c)
            {
                Compatibility = c;
            }
        }
    }
}
