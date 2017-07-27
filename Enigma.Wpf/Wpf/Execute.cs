using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace Enigma.Wpf
{
    public static class Execute
    {
        public static void OnUIThread(Action action)
        {
            var dispatcher = Application.Current.Dispatcher;
            if (dispatcher.CheckAccess())
            {
                action.Invoke();
            }
            else
            {
                dispatcher.Invoke(action);
            }
        }

        public static Task OnUIThreadAsync(Action action)
        {
            var taskSource = new TaskCompletionSource<object>();
            OnUIThread(() =>
            {
                try
                {
                    action();
                    taskSource.SetResult(null);
                }
                catch (Exception exception)
                {
                    taskSource.SetException(exception);
                }
            });
            return taskSource.Task;
        }
    }
}
