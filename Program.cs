using System;

namespace CORTE_3
{
    class Program
    {
        static void Main(string[] args)
        {
           string dato = "";
            int tamaño = 0;
            int actividad = 0;
            int edad = 0;
            double peso = 0.0;
            int opcion = 0;
            
            
            
            do{
                
                Console.WriteLine("Bienvenidos a continuación te indicaré cuanta cantidad de alimento debe consumir tu perro, pero para ello responda algunas preguntas:");
                
                Console.WriteLine("¿Cual es el peso de su perro?:");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                
                Console.WriteLine("¿Cual es el tamaño de su perro?");
                Console.WriteLine("1 - Miniatura");
                Console.WriteLine("2 - Pequeño");
                Console.WriteLine("3 - Mediano");
                Console.WriteLine("4 - Grande");
                dato = Console.ReadLine();
                tamaño = Convert.ToInt32(dato);
                
                Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                dato = Console.ReadLine();
                actividad = Convert.ToInt32(dato);
                
                if(peso <= 5 && peso >= 2) 
                    switch (actividad) {
                        case 1:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 50 gramos");
                              Console.WriteLine("Si tiene 3, 4 o 5 meses debe comer 60 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 55 gramos");
                            break;
                        case 2:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 55 - 100 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 50 gramos");
                              Console.WriteLine("Si tiene 3, 4 o 5 meses debe comer 60 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 55 gramos");
                            break;
                        case 3:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 45 - 85 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 50 gramos");
                              Console.WriteLine("Si tiene 3, 4 o 5 meses debe comer 60 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 55 gramos");
                            break;
                    }
               
                else if(peso <= 10 && peso >= 5) 
                
                    
                    switch (actividad) {
                        case 1:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 115 - 190 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 95-155 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 110-185 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 115-195 gramos");
                              Console.WriteLine("Si tiene 5 meses debe comer 115-190 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 110-185 gramos");
                            break;
                        case 2:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 100 - 170 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 95-155 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 110-185 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 115-195 gramos");
                              Console.WriteLine("Si tiene 5 meses debe comer 115-190 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 110-185 gramos");
                            break;
                        case 3:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 85 - 145 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 95-155 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 110-185 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 115-195 gramos");
                              Console.WriteLine("Si tiene 5 meses debe comer 115-190 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 110-185 gramos");
                            break;
                    }
                    
                else if(peso <= 15 && peso >= 10) 
                
                    
                    switch (actividad) {
                        case 1:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 190 - 255 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 215 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 265 gramos");
                              Console.WriteLine("Si tiene 4 o 5 meses debe comer 285 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 280 gramos");
                            break;
                        case 2:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 170 - 225 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 215 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 265 gramos");
                              Console.WriteLine("Si tiene 4 o 5 meses debe comer 285 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 280 gramos");
                            break;
                        case 3:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 145 - 195 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 215 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 265 gramos");
                              Console.WriteLine("Si tiene 4 o 5 meses debe comer 285 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 280 gramos");
                            break;
                    }
                
              else if(peso <= 25 && peso >= 15) 
            
                    switch (actividad) {
                        case 1:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                                   Console.WriteLine("Su perro debe comer entre 255 - 380 gramos de alimento.");
                              else if (edad==2)
                                   Console.WriteLine("Si tiene 2 meses debe comer 270 gramos");
                                   Console.WriteLine("Si tiene 3 meses debe comer 350 gramos");
                                   Console.WriteLine("Si tiene 4 o 5 meses debe comer 375 gramos");
                                   Console.WriteLine("Si tiene 6-12 meses debe comer 370 gramos");
                            break;
                        case 2:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 225 - 330 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 270 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 350 gramos");
                              Console.WriteLine("Si tiene 4 o 5 meses debe comer 375 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 370 gramos");
                            break;
                        case 3:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 195 - 285 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 270 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 350 gramos");
                              Console.WriteLine("Si tiene 4 o 5 meses debe comer 375 gramos");
                              Console.WriteLine("Si tiene 6-12 meses debe comer 370 gramos");
                            break;
                    }
                else if(peso <= 40 && peso >= 25) 
            
                    switch (actividad) {
                        case 1:
                             Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 380 - 535 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 300-355 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 400-475 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 445-525 gramos");
                              Console.WriteLine("Si tiene 5, 6-12 meses debe comer 450-530 gramos");
                            break;
                        case 2:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 330 - 475 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 300-355 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 400-475 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 445-525 gramos");
                              Console.WriteLine("Si tiene 5, 6-12 meses debe comer 450-530 gramos");
                            break;
                        case 3:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 285 - 410 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 300-355 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 400-475 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 445-525 gramos");
                              Console.WriteLine("Si tiene 5, 6-12 meses debe comer 450-530 gramos");
                            break;
                    }
                else if(peso <= 55 && peso >= 40) 
            
                    switch (actividad) {
                        case 1:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                                if (edad==1)
                                Console.WriteLine("Su perro debe comer entre 535 - 680 gramos de alimento."); 
                                else if (edad==2)
                                Console.WriteLine("Si tiene 2 meses debe comer 405 gramos");
                                Console.WriteLine("Si tiene 3 meses debe comer 545 gramos");
                                Console.WriteLine("Si tiene 4 meses debe comer 610 gramos");
                                Console.WriteLine("Si tiene 5 meses debe comer 625 gramos");
                            break;
                        case 2:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 475 - 600 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 405 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 545 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 610 gramos");
                              Console.WriteLine("Si tiene 5 meses debe comer 625 gramos");
                            break;
                        case 3:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 410 - 520 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 405 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 545 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 610 gramos");
                              Console.WriteLine("Si tiene 5 meses debe comer 625 gramos");
                            break;
                    }
                 else if(peso <= 70 && peso >= 55) 
            
                    switch (actividad) {
                        case 1:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 680 - 820 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 450 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 605 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 685 gramos");
                            break;
                        case 2:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 600 - 720 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 450 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 605 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 685 gramos");
                            break;
                        case 3:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 520 - 620 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 450 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 605 gramos");
                              Console.WriteLine("Si tiene 4 meses debe comer 685 gramos");
                            break;
                    }
                else if(peso <= 90 && peso >= 70) 
            
                    switch (actividad) {
                        case 1:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 820 - 985 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 485 - 580 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 670 gramos");
                            break;
                        case 2:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 720 - 870 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 485 - 580 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 670 gramos");
                            break;
                        case 3:
                            Console.WriteLine("¿Cuál es la edad de su perro? Si es Adulto = 1 o si es Cachorro = 2");
                            dato=Console.ReadLine();
                            edad=Convert.ToInt32(dato);

                              if (edad==1)
                              Console.WriteLine("Su perro debe comer entre 620 - 750 gramos de alimento.");
                              else if (edad==2)
                              Console.WriteLine("Si tiene 2 meses debe comer 485 - 580 gramos");
                              Console.WriteLine("Si tiene 3 meses debe comer 670 gramos");
                            break;
                    }   
                 
                
           
                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
            }while(opcion != 4);

        }
    }
}
