internal class Program
{

    static int acumulador = 0;

    private static void Main()
    {

        CancellationTokenSource cts = new CancellationTokenSource(); //Se crea el objeto tipo CancellationTokenSource que referenciara al CancellationToken
        CancellationToken ctoken = cts.Token; //Se instancia el objeto CancellationToken quien realizara la notificacion de la cancelacion de una tarea

        try
        {
            Task tarea = Task.Run(() => Tarea(ctoken));

            for (int i = 0; i < 100; i++)
            {
                acumulador+=10;
                Thread.Sleep(500);

                if (acumulador > 100)
                {
                    throw new Exception();
                }
            }

            Console.ReadLine();
        }
        catch(Exception)
        {
            cts.Cancel(); //Se cancela la tarea
            Console.WriteLine("Tarea cancelada".ToUpper());
        }
        

        Console.WriteLine("Valor del acumulador: " + acumulador);
        Console.ReadLine();

    }

    static void Tarea(CancellationToken ctokenParameter)
    {
        for (int i = 0; i < 100; i++)
        {
            acumulador++;
            var hilo = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(500);
            Console.WriteLine("TAREA 1: Esta vuelta de bucle corresponde al Thread: " + hilo + ", vuelta nro: " + acumulador);

            if(ctokenParameter.IsCancellationRequested) //el CancellationToken que recibe por parametro lo usa para evaluar si se requiere una cancelacion
            {
                acumulador = 0; //Se devuelve el código (en este caso simple un acumulador) al estado original como seria un RollBack en una base de datos.
                return; //utilizamos return para volver al flujo de ejecucion principal.
            }

        }
    }

}

/* 

-------------------------------------------------------- CANCELACIÓN DE TASKS ----------------------------------------- 


    static int acumulador = 0;

    private static void Main()
    {

        CancellationTokenSource cts = new CancellationTokenSource(); //Se crea el objeto tipo CancellationTokenSource que referenciara al CancellationToken
        CancellationToken ctoken = cts.Token; //Se instancia el objeto CancellationToken quien realizara la notificacion de la cancelacion de una tarea

        try
        {
            Task tarea = Task.Run(() => Tarea(ctoken));

            for (int i = 0; i < 100; i++)
            {
                acumulador+=10; //Es quien va a crear la situacion para que se cumpla la condicion de Cancelacion y representaria una posible excepcion
                Thread.Sleep(500);

                if (acumulador > 100)
                {
                    throw new Exception();
                }
            }

            Console.ReadLine();
        }
        catch(Exception)
        {
            cts.Cancel(); //Se cancela la tarea
            Console.WriteLine("Tarea cancelada".ToUpper());
        }
        

        Console.WriteLine("Valor del acumulador: " + acumulador);
        Console.ReadLine();

    }

    static void Tarea(CancellationToken ctokenParameter)
    {
        for (int i = 0; i < 100; i++)
        {
            acumulador++;
            var hilo = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(500);
            Console.WriteLine("TAREA 1: Esta vuelta de bucle corresponde al Thread: " + hilo + ", vuelta nro: " + acumulador);

            if(ctokenParameter.IsCancellationRequested) //el CancellationToken que recibe por parametro lo usa para evaluar si se requiere una cancelacion
            {
                acumulador = 0; //Se devuelve el código (en este caso simple un acumulador) al estado original como seria un RollBack en una base de datos.
                return; //utilizamos return para volver al flujo de ejecucion principal.
            }

        }
    }

-------------------------------------------------------- CLASE PARALLEL ----------------------------------------- 

Nos permite trabajar con varias tareas de manera eficaz y eficiente.
Su nombre se refiere al paralelísmo y como trabajar con tareas asincronicas y paralelas.

    private static int acumulador = 0;

        (MAIN)
        Parallel.For(0, 100, RealizarTarea);

        Console.ReadKey();


    static void RealizarTarea(int dato)
    {

        Console.WriteLine($"Acumulador: {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");

        if ((acumulador%2) == 0)
        {

            acumulador += dato;
            Thread.Sleep(100);

        }
        else
        {

            acumulador -= dato;
            Thread.Sleep(100);

        }

    }


.......... O UNA MANERA MAS SIMPLIFICADA CON LAMBDAS:

        Parallel.For(0, 100, dato=>
        {

            Console.WriteLine($"Acumulador: {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");
            if ((acumulador % 2) == 0)
            {

                acumulador += dato;
                Thread.Sleep(100);

            }
            else
            {

                acumulador -= dato;
                Thread.Sleep(100);

            }
        });

        Console.ReadKey();



-------------------------------------------------------- TASK o TAREAS III ----------------------------------------- 

//METODOS DE TASK:

Task1.Wait(); //Espera a la tarea 1 para seguir con el flujo

Task.WaitAll(tasks); //Espera a TODAS las tasks que le paso por parametro o un arreglo de tasks.

Task.WaitAny(tasks); //Espera a CUALQUIERA de las tasks que le paso por parametro o un arreglo de tasks.



    static void RealizarTodasTareas()
    {

        var Task1 = Task.Run(() => 
        {

            Tarea();

        });

        var Task2 = Task.Run(() =>
        {

            Tarea2();

        });

        Task[] tasks = new Task[] { Task1, Task2};

        Task.WaitAll(tasks);

        var Task3 = Task.Run(() =>
        {

            Tarea3();

        });

    }



    static void Tarea()
    {
        for (int i = 0; i < 5; i++)
        {
            var hilo = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(1000);
            Console.WriteLine("TAREA 1: Esta vuelta de bucle corresponde al Thread: " + hilo);
        }
    }
/// TAREA X3

-------------------------------------------------------- TASK o TAREAS II -----------------------------------------

        Task tareaNueva = Task.Run(()=>Tarea()); //simplificar la instancia y ejecucion de la task

        Task tareaNueva2 = tareaNueva.ContinueWith(Tarea2); //comenzar la tarea nueva2 cuando se termine la tarea1

-------------------------------------------------------- TASK o TAREAS I -----------------------------------------

Utiliza un Pool de Threads que sirven para ejecutar tareas de manera optimizada. Las task gestiona recursos para manejar hilos correctamente.
Es una PROMESA que utiliza los Hilos o Threads como herramientas para conseguir esa promesa.
Promete que la tarea se realizara mediante los hilos y devuelve el resultado como Promesa o compromiso CUMPLIDO o INCUMPLIDO. 
Es parte de la programacion Asincrónica.


        Task tarea = new Task(EjecutarTarea);

        Task tarea2 = new Task(() => 
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hora actual: " + DateTime.Now);
                Thread.Sleep(1000);
            }
        });

        tarea.Start();
        tarea2.Start();

        Console.ReadLine();



    static void EjecutarTarea()
    {

        for (int i = 0; i < 100; i++)
        {
            var hilo = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(1000);
            Console.WriteLine("Esta vuelta de bucle corresponde al Thread: " + hilo);
        }

    }

-------------------------------------- THREAD POOL  optimizacion y reutilizacion de Hilos -----------------------------------------

        
        (MAIN)
        for (int i = 0; i < 100; i++)
        {

            ThreadPool.QueueUserWorkItem(EjecutarTarea, i);

        }

        Console.ReadLine();
        -----


    static void EjecutarTarea(Object O)
    {
        int nTarea = (int)O;

        Console.WriteLine("Thread Nro: " + Thread.CurrentThread.ManagedThreadId + " ha comenzado la tarea Nro: " + nTarea);

        Thread.Sleep(1000);

        Console.WriteLine("Thread Nro: " + Thread.CurrentThread.ManagedThreadId + " ha terminado la tarea: " + nTarea);
    }



  --------------------------------- THREADS, CONTROL DE TAREAS TASKS, BLOQUEO LOCK Y DEMAS. -----------------------------


 
 var ResultadoTarea = new TaskCompletionSource<bool>();

        Thread h1 = new Thread(() => 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hilo 1: " + (i+1));
                Thread.Sleep(1000);
            }

            ResultadoTarea.TrySetResult(true); //cuando el flujo de ejecución llegue a este punto dara por completada este hilo o tarea (task)

        });

        Thread h2 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hilo 2: " + (i + 1));
                Thread.Sleep(1000);
            }

            ResultadoTarea.TrySetResult(true);

        });

        Thread h3 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hilo 3: " + (i + 1));
                Thread.Sleep(1000);
            }
        });

        h1.Start();


        h2.Start();


        var resultado = ResultadoTarea.Task.Result;
        Console.WriteLine("Se ha terminado la tarea 1 y 2 comienza la tarea 3");
        h3.Start();
*/
