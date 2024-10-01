//Events
Publisher publisher = new();

Subscriber subscriber1 = new Subscriber("Sub1");
Subscriber subscriber2 = new Subscriber("Sub2");
Subscriber subscriber3 = new Subscriber("Sub3");

//Subscribe to event
publisher.Message += subscriber1.OnMessageRecieved;
publisher.Message += subscriber2.OnMessageRecieved;
publisher.Message += subscriber3.OnMessageRecieved;

//Send (raise) event
publisher.SendMessage();

Console.WriteLine();
//Unsubscribe to event
publisher.Message -= subscriber3.OnMessageRecieved;

publisher.SendMessage();

//With Data
publisher.MessageWithData += subscriber1.OnMessageRecieved;
publisher.MessageWithData += subscriber2.OnMessageRecieved;
publisher.MessageWithData += subscriber3.OnMessageRecieved;

publisher.SendMessageWithData("Vad kul!");
Console.WriteLine();

//Generic
publisher.GenericMessage += subscriber1.OnMessageRecieved;
publisher.SendGenericMessage();

Console.WriteLine();

publisher.GenericMessageWithData += subscriber1.OnMessageRecieved;
publisher.SendGenericMessageWithData("Vad kul!");

