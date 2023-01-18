namespace Stack_and_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stack stack=new Stack();
            //stack.push(56);
            //stack.push(30);
            //stack.push(70);
            //stack.Display();

            //stack.peek();
            //stack.Display();
            //stack.pop();
            //stack.Display();

            Queue queue = new Queue();
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.Display();
            queue.dequeue();
            queue.Display();
           
        }
    }
}
