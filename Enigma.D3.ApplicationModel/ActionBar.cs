using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Preferences;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class ActionBar
    {
        public ActiveSkill PrimaryAction { get; } = new ActiveSkill { Hotkey = new Hotkey { PrimaryGesture = new KeyGesture { Key = Key.Mouse1 }, SecondaryGesture = KeyGesture.None } };
        public ActiveSkill SecondaryAction { get; } = new ActiveSkill { Hotkey = new Hotkey { PrimaryGesture = new KeyGesture { Key = Key.Mouse2 }, SecondaryGesture = KeyGesture.None } };
        public ActiveSkill Hotbar1 { get; } = new ActiveSkill();
        public ActiveSkill Hotbar2 { get; } = new ActiveSkill();
        public ActiveSkill Hotbar3 { get; } = new ActiveSkill();
        public ActiveSkill Hotbar4 { get; } = new ActiveSkill();
        public ActiveSkill Potion { get; } = new ActiveSkill();

        public ActiveSkill[] Hotbar => new[] { Hotbar1, Hotbar2, Hotbar3, Hotbar4 };
    }
}
