using System;
using System.Collections;
namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=0;
            string value="";
            int c=0;
            
            Console.WriteLine("DEMOSTRACION DE PILAS Y COLAS");            
            do{
                Console.WriteLine("1. Pilas");
                Console.WriteLine("2. Colas");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Seleccione la opción deseada: "); 
                op=Convert.ToInt32(Console.ReadLine());
                
                //pila
                switch(op)
                {
                    case 1: //pila
                            Stack myStack= new Stack();
                            do{
                               Console.WriteLine("1. Apilar");
                               Console.WriteLine("2. Desapilar");
                               Console.WriteLine("3. Desapilar todo");         
                               Console.WriteLine("4. Regresar el menu anterior");        
                               Console.WriteLine("Seleccione la opción deseada: "); 
                               op=Convert.ToInt32(Console.ReadLine());

                               switch(op)
                               {
                                    case 1: //apilar
                                        Console.WriteLine("Ingrese el valor a apilar");
                                        value=Console.ReadLine();
                                        myStack.Push(value);
                                        Console.WriteLine("Valor ingresado con éxito presione una tecla para continuar ......");
                                        Console.ReadKey();
                                        break;
                                    case 2: //desapilar
                                        if(myStack.Count==0){
                                            Console.WriteLine("No es posible desapilar, ya que la pila se encuentra vacia");
                                        }else{
                                            Console.WriteLine($"Valor desapilado: {myStack.Pop()}");
                                        }
                                        Console.ReadKey();
                                        break;
                                    case 3: //desapilar todo
                                        c=myStack.Count;
                                        Console.WriteLine("Desapilando todos los valores");
                                        Console.WriteLine("-----------------------------");
                                        for(int x=1; x<=c; x++){
                                           Console.WriteLine($"Valor desapilado: {myStack.Pop()}");    
                                        }
                                        Console.WriteLine("Todos los valores fueron desapilados con exito.");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.WriteLine("Retornando al menu anterior");
                                        break;
                                    default:
                                        Console.WriteLine("Opción invalida intente una nueva opción");
                                        break;
                               }
                               Console.ReadKey();

                            } while(op!=4);
                            break;
                    case 2: //cola
                            Queue myQueue= new Queue();
                             do{
                               Console.WriteLine("1. Encolar");
                               Console.WriteLine("2. Desencolar");
                               Console.WriteLine("3. Desencolar todo");         
                               Console.WriteLine("4. Regresar el menu anterior");        
                               Console.WriteLine("Seleccione la opción deseada: "); 
                               op=Convert.ToInt32(Console.ReadLine());
                               
                               switch(op)
                               {
                                   case 1: // encolar
                                        Console.WriteLine("Ingrese el valor a encolar");
                                        value=Console.ReadLine();
                                        myQueue.Enqueue(value);
                                        Console.WriteLine("Valor ingresado con éxito presione una tecla para continuar ......");
                                        Console.ReadKey();
                                        break;
                                   case 2: // desencolar
                                        if(myQueue.Count==0){
                                             Console.WriteLine("No es posible desencolar, ya que la cola se encuentra vacia");
                                        }else{
                                            Console.WriteLine($"Valor desencolado: {myQueue.Dequeue()}");
                                        }
                                        Console.ReadKey();
                                        break;
                                   case 3: // desencolar todo
                                        c=myQueue.Count;
                                        Console.WriteLine("Desencolando todos los valores");
                                        Console.WriteLine("-----------------------------");
                                        for(int x=1; x<=c; x++){
                                            Console.WriteLine($"Valor desencolado: {myQueue.Dequeue()}");
                                        }
                                        Console.WriteLine("Todos los valores fueron desencolados con exito.");
                                        Console.ReadKey();
                                        break;
                                   case 4:
                                        Console.WriteLine("Retornando al menu anterior");
                                        break;
                                   default:
                                        Console.WriteLine("Opción invalida intente una nueva opción");
                                        break;
                               }
                               Console.ReadKey();
                            } while(op!=4);
                            break;
                    case 3: 
                        Console.WriteLine("Hasta luego!!!");
                        break;
                }
            }while(op!=3);
            Console.ReadKey();
        }
    }
}
