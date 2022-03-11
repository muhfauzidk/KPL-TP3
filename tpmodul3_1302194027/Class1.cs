using System;

    public class Program
    {
        enum State { terkunci, terbuka, EXIT };
        public static void Main()
        {
            State state = State.terkunci;
            string[] screenName = { "terkunci", "tidak terkunci" };
            while (state != State.EXIT)
            {
                Console.WriteLine("Pintu " + screenName[(int)state]);
                Console.Write("Enter Command : ");
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.terkunci:
                        if (command == "KunciPintu")
                            state = State.terkunci;
                        else if (command == "BukaPintu")
                            state = State.terbuka;
                        else if (command == "QUIT")
                            state = State.EXIT;
                        else
                            state = State.terkunci;
                        break;
                    case State.terbuka:
                        if (command == "KunciPintu")
                            state = State.terkunci;
                        else if (command == "BukaPintu")
                            state = State.terbuka;
                        else if (command == "QUIT")
                            state = State.EXIT;
                        else
                            state = State.terbuka;
                    break;
                }
            }
            Console.WriteLine("EXIT SCREEN");
        }
    }
