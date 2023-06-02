using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaUtility.HotKeys
{
    [Serializable]
    public class Options
    {
        public string? Description { get; set; }
        public ModifierKeys ModifierKeys { get; set; } = ModifierKeys.Alt;
        public Keys Key { get; set; }
        public System.Timers.Timer? Timer { get; set; }
    }

}
