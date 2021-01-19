using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Threading;

namespace BlazorServer.Pages.Pomodoro
{
    public class PomodoroClockBase : ComponentBase, IDisposable
    {
        private Timer timer;
        private int totalTime = 25 * 60;

        protected string formattedTimer => TimeSpan.FromSeconds(totalTime).ToString(@"mm\:ss");
        protected bool isStart { get; set; } = false;
        protected bool isStop { get; set; } = true;
        protected bool isReset { get; set; } = true;
        protected bool isResume { get; set; } = true;

        protected void Start()
        {
            timer?.Dispose();
            CountDown();
            
            isStart = !isStart;
            isStop = !isStop;
        }

        protected void Stop()
        {
            timer?.Dispose();
            isStop = !isStop;
            isReset = !isReset;
            isResume = !isResume;
        }

        protected void Reset()
        {
            timer?.Dispose();
            totalTime = 25 * 60;

            isStart = !isStart;
            isReset = !isReset;
            isResume = !isResume;
        }

        protected void Resume()
        {
            timer?.Dispose();
            CountDown();

            isResume = !isResume;
            isStop = !isStop;
            isReset = !isReset;
        }

        public void Dispose()
        {
            timer?.Dispose();
        }

        private void CountDown()
        {
            timer = new Timer(_ =>
            {
                if (totalTime > 0)
                {
                    totalTime -= 1;
                    InvokeAsync(StateHasChanged);
                }
            }, null, 0, 1000);
        }

        protected string ChangeColor() 
        {
            return (totalTime < 25 * 60) ? "red" : "#333";
        } 
    }
}
