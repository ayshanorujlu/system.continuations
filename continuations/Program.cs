
#region WhenAll

//var t0 = Task.Run(() =>
//{
//    Console.WriteLine("Task0");
//    Thread.Sleep(4000);
//    throw new Exception("My error");
//});

//var t1 = Task.Run(() =>
//{
//    Console.WriteLine("Task1");
//    throw new Exception("My error");
//});

//var t3 = Task.Run(() =>
//{

//    Console.WriteLine("Task3");
//    throw new Exception("My error");
//});

//await Task.WhenAll(t0, t1);
//await t3;

#endregion

#region MultipleContuniation
//public class MultipleContinue {
//    public static async Task Main()
//    {
//        var task = Task.Run(
//           () =>
//           {
//               DateTime date = DateTime.Now;
//               return date.Hour > 17
//                   ? "evening"
//                   : date.Hour > 12
//                       ? "afternoon"
//                       : "morning";
//           });

//        await task.ContinueWith(
//            antecedent =>
//            {
//                Console.WriteLine($"Good {antecedent.Result}!");
//                Console.WriteLine($"And how are you this fine {antecedent.Result}?");
//            }, TaskContinuationOptions.OnlyOnRanToCompletion);
//    }
//}

#endregion

#region WithChild

//Task parent = Task.Factory.StartNew(() =>
//{
//    Console.WriteLine("Starting child task...");

//    Task child = Task.Factory.StartNew(() =>
//    {
//        Console.WriteLine("Child task is running. Going to sleep for a sec.");
//        Thread.Sleep(1000);
//        Console.WriteLine("Child task's finished and throws an exception.");
//        throw new Exception();
//    }, TaskCreationOptions.AttachedToParent);

//    child.ContinueWith(antecedent =>
//    {
//        Console.WriteLine("Continuation of child task is running");
//        Thread.Sleep(3000);
//        Console.WriteLine("Continuation's finished");
//    }, TaskContinuationOptions.AttachedToParent
//        | TaskContinuationOptions.OnlyOnFaulted);
//});

//try
//{
//    Console.WriteLine("Waiting for parent task");
//    parent.Wait();
//    Console.WriteLine("Parent task finished");
//}
//catch (AggregateException ex)
//{
//    Console.WriteLine("Exception: {0}", ex.InnerException.GetType());
//}

#endregion