using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Promodoro.Pages
{
    public class TimerBase : ComponentBase, IDisposable
    {
        private System.Threading.Timer timer;
        private int totalTime = 25 * 60;
        protected string remaining => TimeSpan.FromSeconds(totalTime).ToString(@"mm\:ss");

        protected string color = "";
        protected bool isStart = false;
        protected bool isStop = true;
        protected bool isReset = true;

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        protected void Start()
        {
            timer?.Dispose();
            timer = new System.Threading.Timer(_ =>
            {
                if (totalTime > 0)
                {
                    totalTime -= 1;
                    Console.WriteLine("timer ticked");
                    StateHasChanged();
                    JSRuntime.InvokeVoidAsync("setTitle", remaining);
                }
            }, null, 0, 1000);
            isStart = true;
            isStop = false;
            isReset = false;
        }

        protected void Stop()
        {
            timer?.Dispose();
            isStart = false;
            isStop = true;
            isReset = false;
        }

        protected void Reset()
        {
            totalTime = 25 * 60;
            timer?.Dispose();
            isStart = false;
            isStop = true;
            isReset = true;
        }

        protected string changeColor()
        {
            return (totalTime <= 60 * 5) ? "red" : "";
        }

        public void Dispose()
        {
            timer?.Dispose();
        }
    }
}
