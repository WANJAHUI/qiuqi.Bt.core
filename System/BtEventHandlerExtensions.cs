using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.System
{
    public static class BtEventHandlerExtensions
    {
        public static void InvokeSafely(this EventHandler eventHandler, object sender)
        {
            eventHandler.InvokeSafely(sender,EventArgs.Empty);
        }
        public static void InvokeSafely(this EventHandler eventHandler, object sender, EventArgs e)
        {
            eventHandler(sender, e);

        }
        public static void InvokeSafely<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) where TEventArgs : EventArgs
        {
            eventHandler(sender, e);

        }


        }
}
