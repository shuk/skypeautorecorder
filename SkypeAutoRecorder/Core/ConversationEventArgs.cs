using System;

namespace SkypeAutoRecorder.Core
{
    /// <summary>
    /// Conversation event arguments which provides caller name.
    /// </summary>
    internal class ConversationEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventArgs"/> class.
        /// </summary>
        /// <param name="callerName">Name of the caller.</param>
        public ConversationEventArgs(string callerName)
        {
            CallerName = callerName;
        }

        /// <summary>
        /// Gets or sets the name of the caller.
        /// </summary>
        /// <value>
        /// The name of the caller.
        /// </value>
        public string CallerName { get; set; }
    }
}