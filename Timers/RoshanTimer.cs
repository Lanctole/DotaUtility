using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DotaUtility.Timers
{
    internal class RoshanTimer
    {
        public static async Task Start()
        {
            var timer = new System.Timers.Timer(480000); // Roshan minimal up-timer = 8 minutes 480000
            timer.AutoReset = false;
            timer.Elapsed += async (sender, e) =>
            {
                await PlaySound();
            };
            timer.Start();

            //await Task.Delay(6000);
        }

        private static async Task PlaySound()
        {
            Stream stream = Resources.rosh_death_sound;
            SoundPlayer player = new SoundPlayer(stream);
            //player.Load( Resources.rosh_death_sound);
            //player.SoundLocation =;
            player.Load();

            await Task.Run(() =>
            {
                player.Play();
            });
        }
    }
}
