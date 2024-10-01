//Publisher

class MessageEventArgs : EventArgs
{
    public string Message { get; set; }

    public MessageEventArgs(string message)
    {
        Message = message;
    }
}

class Publisher
{
    //This definition is the standard best practe definition.
    public delegate void MessageEvent(object sender, EventArgs args);
    public delegate void MessageEventWithData(object sender, MessageEventArgs args);

    public event MessageEvent Message;
    public event MessageEventWithData MessageWithData;
    public event EventHandler GenericMessage;
    public event EventHandler<MessageEventArgs> GenericMessageWithData;

    public void SendMessage()
    {
        Message.Invoke(this, EventArgs.Empty);
    }
    public void SendMessageWithData(string message)
    {
        MessageWithData.Invoke(this, new MessageEventArgs(message));
    }
    public void SendGenericMessage()
    {
        GenericMessage.Invoke(this, EventArgs.Empty);
    }
    public void SendGenericMessageWithData(string message)
    {
        GenericMessageWithData.Invoke(this, new MessageEventArgs(message));
    }
}
