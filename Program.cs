// using System;

// public class TestOperacionesBancarias{
        
//     static void Main(string[] args){
//         Console.WriteLine("CAJERO AUTOMATICO APP"); 
//         string numeroCuenta="";
//         int opc2 = 0;
//         int opc3 =0;
//         string validNip ="";
//         int intentos =0;
//         double deposito =0;
//         double retiro =0;
//         int user =0;
//         double transferencia=0;
//         string newNip="";
//         CuentaBancaria usuario = null;
//         CuentaBancaria usuario2 = null;
//         // CuentaBancaria usuario = new CuentaBancaria();
//         // CuentaBancaria usuario2 = new CuentaBancaria();
//         Console.WriteLine("Ingresa el nombre del titular: ");
//         string nombre = Console.ReadLine();
        
//         if (string.IsNullOrWhiteSpace(nombre)) {
//             Console.WriteLine("El nombre no puede estar vacío");
//             return; 
//         }
        
        
//         Console.WriteLine("Ingresa el saldo inicial del titular: ");
         
//         if (double.TryParse(Console.ReadLine(), out double saldo)&& saldo > 0){
//             Console.WriteLine("Ingrese un nip: ");
//             string nip = Console.ReadLine();
//             if (string.IsNullOrWhiteSpace(nip)) {
//                 Console.WriteLine("El nip no puede estar vacío");
//                 return; 
//             }else{
                
//                 usuario = new CuentaBancaria(nombre, saldo, nip);
//                 numeroCuenta=aleatorio();
//                 usuario.NumeroCuenta = numeroCuenta;
                
                
//             }      
//         }else{
//             Console.WriteLine("OPCIÓN INVALIDA");
//             return;
//         }
//         //----------------------------------------------------
//         Console.WriteLine("---------------------------------");
//         Console.WriteLine("Ingresa el nombre del titular2: ");
//         string nombre2 = Console.ReadLine();
//         if (string.IsNullOrWhiteSpace(nombre2)) {
//                 Console.WriteLine("El nombre no puede estar vacío");
//                 return; 
//         }
//         Console.WriteLine("Ingresa el saldo inicial del titular: ");
         
//         if (double.TryParse(Console.ReadLine(), out double saldo2) && saldo2 > 0){
//             Console.WriteLine("Ingrese un nip: ");
//             string nip2 = Console.ReadLine();
//             if (string.IsNullOrWhiteSpace(nip2)) {
//                 Console.WriteLine("El nombre no puede estar vacío");
//                 return; 
//             }else{
//                 //CuentaBancaria usuario2 = new CuentaBancaria(nombre2, saldo2, nip2);
//                 usuario2 = new CuentaBancaria(nombre2, saldo2, nip2);
//                 // usuario2.CuentaBancaria(nombre2, saldo2, nip2);
//                 numeroCuenta=aleatorio();
//                 // Console.WriteLine($"numero de ccuenta:{numeroCuenta}");
//                 usuario2.NumeroCuenta = numeroCuenta;
//                 // Console.WriteLine(usuario.NumeroCuenta);
                
//             }      
//         }else{
//             Console.WriteLine("OPCIÓN INVALIDA");
//             return;
//         }
//         do{
//             Console.WriteLine("////////////////////////////////////////");
//             Console.WriteLine("                MENÚ    ");
//             Console.WriteLine("1.- Numero de cueta: " + usuario.NumeroCuenta);
//             Console.WriteLine("2-. Numero de cueta: " + usuario2.NumeroCuenta);
//             Console.WriteLine("3.- Salir del cajero");
//             if (int.TryParse(Console.ReadLine(), out opc2)){
//                 switch(opc2){
//                     case 1:
                        
//                         do{
//                             Console.WriteLine("para validar su identidad ingrese su nip: ");
//                             validNip = Console.ReadLine();
//                             if(validNip.Equals(usuario.Nip)){
//                                 intentos = 4;
//                                 Console.WriteLine("Su nip es valida, Bienvenido : " + usuario.NombreTitular);
//                                 do{
//                                     Console.WriteLine("1.- Consultar saldo");
//                                     Console.WriteLine("2.- Depositar efectivo");
//                                     Console.WriteLine("3.- Retirar efectivo");
//                                     Console.WriteLine("4.- Transferir entre cuentas");
//                                     Console.WriteLine("5.- Cambiar NIP");
//                                     Console.WriteLine("6.- Cerrar sesión");
//                                     if (int.TryParse(Console.ReadLine(), out opc3)){
//                                         switch(opc3){
//                                             case 1:
//                                                 Console.WriteLine("Consultar saldo");
//                                                 Console.WriteLine("TU SALDO ACTUAL ES DE: $" + usuario.SaldoCuenta);
//                                                 break;
//                                             case 2:
//                                                 Console.WriteLine("Depositar efectivo");
//                                                 Console.WriteLine("Cuánto dinero quieres depositar?");
//                                                 if (double.TryParse(Console.ReadLine(), out deposito)&& deposito > 0){
//                                                     // usuario.SaldoCuenta = usuario.SaldoCuenta + deposito;
//                                                     usuario.depositar(deposito);
//                                                 }else{
//                                                     Console.WriteLine("CANTIDAD INCORRECTA");
//                                                 }

//                                                 break;
//                                             case 3:
//                                                 Console.WriteLine("Retirar efectivo");
//                                                 Console.WriteLine("Cuánto dinero quieres retirar?");
//                                                 if (double.TryParse(Console.ReadLine(), out retiro)&& retiro > 0){
//                                                     usuario.retirar(retiro);
//                                                 }else{
//                                                     Console.WriteLine("CANTIDAD INCORRECTA");
//                                                 }
//                                                 break;
//                                             case 4:
//                                                 Console.WriteLine("Transferir entre cuenta");
//                                                 user = 1;
//                                                 Console.WriteLine("Cuánto dinero quieres transferir a la cuenta de: "+ usuario2.NombreTitular+ " con numero de cuenta: "+ usuario2.NumeroCuenta + " ?");
//                                                 if (double.TryParse(Console.ReadLine(), out transferencia)&& transferencia > 0){
//                                                     usuario.transferir(transferencia, user);
                                                    
//                                                 }else{
//                                                     Console.WriteLine("CANTIDAD INCORRECTA");
//                                                 }
//                                                 break;
//                                             case 5:
//                                                 // Console.WriteLine("Cambiar NIP");
//                                                 // Console.WriteLine("Ingrese su nuevo NIP: ");
//                                                 // newNip = Console.ReadLine();
//                                                 // if (string.IsNullOrWhiteSpace(nip)) {
//                                                 //     Console.WriteLine("El nip no puede estar vacío");
//                                                 //     return; 
//                                                 // }else{
//                                                 //     Console.WriteLine("Está seguro decambiar su NIP? 1.- SI   2.- NO");
//                                                 //     int respN = Console.ReadLine();
//                                                 //     if (respN == 1){
//                                                 //         usuario.Nip = newNip;
//                                                 //     }else if(respN == 2){
//                                                 //         usuario.Nip = usuario.Nip;
//                                                 //     }else{
//                                                 //         Console.WriteLine("OPCION INVALIDA");
//                                                 //     }
//                                                 // }
                                                
//                                                 break;
//                                             case 6:
//                                                 Console.WriteLine("Cerrar sesión");
//                                                 break;
//                                             default:
//                                                 break;
//                                         }
//                                     }else{
//                                         Console.WriteLine("Opcion invalido");
//                                     }


//                                 }while(opc3 != 6);

//                             }else{
//                                 Console.WriteLine("No se pudo validar su nip para la cuenta: " + usuario.NumeroCuenta);
//                                 Console.WriteLine("NIP incorrecto. Le quedan " + (2 - intentos) + " intentos.");
//                                 intentos++;
//                             }
//                         }while(intentos < 3);
                        
//                         break;
//                     case 2:
//                         break;
//                     case 3:
//                         break;
//                     default:
//                         Console.WriteLine("opción invalida");
//                         break;
//                 }
//             }else{
//                 Console.WriteLine("Opción invalida");
//             }

//         }while(opc2 != 3);
        
//     }
    
//     static string aleatorio(){
//         string numeroCuenta = "";
//         Random ran = new Random();

//         int n1 = ran.Next(1, 9);
//         int n2 = ran.Next(1, 9);
//         int n3 = ran.Next(1, 9);
//         int n4 = ran.Next(1, 9);
//         int n5 = ran.Next(1, 9);
//         int n6 = ran.Next(1, 9);
//         int n7 = ran.Next(1, 9);
//         int n8 = ran.Next(1, 9);

//         numeroCuenta = "" + n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8;
//         // Console.WriteLine(numeroCuenta);
//         return numeroCuenta;
//     }
// }
