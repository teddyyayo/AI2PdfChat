﻿namespace ChatTheDoc.Client
{
    public class ChatMessage
    {
        public string Message { get; set; }
        public string Content { get; set; }

        public ChatMessageType Type { get; set; }

        public ChatMessage(string message, ChatMessageType type)
        {
            Message = message;
            Type = type;
        }

        public enum ChatMessageType
        {
            User,
            Assistant
        }
    }
}
