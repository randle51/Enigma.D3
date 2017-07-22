using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Controls
{
    public class Control : MemoryObject
    {
        public static int SizeOf => SymbolTable.PlatformSize(0x450, 0x470);

        public Ptr VTable => Read<Ptr>(0x00);
        private Ptr _p3 => Read<Ptr>(0x08); // (*) => Ptr[5]
        private int _i2 => this.PlatformRead<int>(0x0C, 0x10);
        private int _i3 => this.PlatformRead<int>(0x10, 0x14);
        public uint Flags => this.PlatformRead<uint>(0x14, 0x18);
        public Ptr<Control> _p0 => this.PlatformRead<Ptr<Control>>(0x18, 0x20);
        public Ptr<Control> _p1 => this.PlatformRead<Ptr<Control>>(0x1C, 0x28);
        public UIID UIID => this.PlatformRead<UIID>(0x20, 0x30);
        public UIID ParentUUID => this.PlatformRead<UIID>(0x228, 0x238);
        public ControlType Type => this.PlatformRead<ControlType>(0x430, 0x440);
        private Ptr _p2 => this.PlatformRead<Ptr>(0x434, 0x448);
        private SNO _i6 => this.PlatformRead<SNO>(0x438, 0x450);
        private int _i7 => this.PlatformRead<int>(0x43C, 0x454);
        private int _i8 => this.PlatformRead<int>(0x440, 0x458);
        private int _i9 => this.PlatformRead<int>(0x444, 0x45C);
        private Ptr _p4 => this.PlatformRead<Ptr>(0x448, 0x460);
        private Ptr _p5 => this.PlatformRead<Ptr>(0x44C, 0x468);

        public bool IsVisible => (Flags & 0x04) != 0;

        /// <summary>
        /// Most control types inherit from <see cref="ControlType.ControlGroup"/> and this is where
        /// <see cref="UIRect"/> comes from. Types without this are <see cref="ControlType.Hotkey"/>,
        /// <see cref="ControlType.DrawHook"/>, <see cref="ControlType.Storyboard"/> and the root type
        /// <see cref="ControlType.Control"/>.
        /// </summary>
        public bool HasUIRect => !_noSizeControls.Contains(Type);

        public UIRect UIRect => HasUIRect ? this.PlatformRead<UIRect>(0x468, 0x498) : new UIRect();

        private static ControlType[] _noSizeControls = new[] { ControlType.Control, ControlType.Hotkey, ControlType.DrawHook, ControlType.Storyboard };

        public override string ToString() => UIID.Name;
    }
}
