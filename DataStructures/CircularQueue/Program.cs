using CircularQueue;

MyCircularQueue myCircularQueue = new MyCircularQueue(3);
Console.WriteLine(myCircularQueue.EnQueue(1)); // return True
Console.WriteLine(myCircularQueue.EnQueue(2)); // return True
Console.WriteLine(myCircularQueue.EnQueue(3)); // return True
Console.WriteLine(myCircularQueue.EnQueue(4)); // return False
Console.WriteLine(myCircularQueue.Rear());     // return 3
Console.WriteLine(myCircularQueue.IsFull());   // return True
Console.WriteLine(myCircularQueue.DeQueue());  // return True
Console.WriteLine(myCircularQueue.EnQueue(4)); // return True
Console.WriteLine(myCircularQueue.Rear());     // return 4