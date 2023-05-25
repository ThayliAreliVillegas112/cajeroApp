using System;

public class TestOperacionesBancarias{
    
    static void Main(string[] args){
        Console.WriteLine("****************************************");
        Console.WriteLine("         CAJERO AUTOMATICO APP"); 
        Console.WriteLine("****************************************");
        CuentaBancaria usuario1 = null;
        CuentaBancaria usuario2 = null;
        string numeroCuenta="";
        int opc2 = 0;
        int opc3 =0;
        string validNip ="";
        int intentos =0;
        double deposito =0;
        double retiro =0;
        int user =0;
        double transferencia=0;
        string newNip="";
        
        Console.WriteLine("Ingresa el nombre del titular: ");
        string nombre = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(nombre)) {
            Console.WriteLine("El nombre no puede estar vacío");
            return; 
        }
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Ingresa el saldo inicial del titular: ");
         
        if (double.TryParse(Console.ReadLine(), out double saldo)&& saldo > 0){
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ingrese un nip: ");
            string nip = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nip)) {
                Console.WriteLine("El nip no puede estar vacío");
                return; 
            }else{
                
                usuario1 = new CuentaBancaria(nombre, saldo, nip);
                numeroCuenta=aleatorio();
                usuario1.NumeroCuenta = numeroCuenta;                
            }      
        }else{
            Console.WriteLine("OPCIÓN INVALIDA");
            Console.WriteLine("------------------------------------------------------");
            return;
        }
        //----------------------------------------------------
        
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Ingresa el nombre del titular2: ");
        string nombre2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre2)) {
                Console.WriteLine("El nombre no puede estar vacío");
                return; 
        }
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Ingresa el saldo inicial del titular: ");
         
        if (double.TryParse(Console.ReadLine(), out double saldo2) && saldo2 > 0){
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ingrese un nip: ");
            string nip2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nip2)) {
                Console.WriteLine("El nombre no puede estar vacío");
                return; 
            }else{
                usuario2 = new CuentaBancaria(nombre2, saldo2, nip2);
                numeroCuenta=aleatorio();
                usuario2.NumeroCuenta = numeroCuenta;
            }      
        }else{
            Console.WriteLine("OPCIÓN INVALIDA");
            Console.WriteLine("------------------------------------------------------");
            return;
        }
        do{
            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine("                MENÚ    ");
            Console.WriteLine("1.- Numero de cueta: " + usuario1.NumeroCuenta);
            Console.WriteLine("2-. Numero de cueta: " + usuario2.NumeroCuenta);
            Console.WriteLine("3.- Salir del cajero");
            if (int.TryParse(Console.ReadLine(), out opc2)){
                Console.WriteLine("////////////////////////////////////////");
                switch(opc2){
                    case 1:
                        
                        do{
                            Console.WriteLine("Para validar su identidad ingrese su nip: ");
                            validNip = Console.ReadLine();
                            Console.WriteLine("--------------------------------------------------");
                            if(validNip.Equals(usuario1.Nip)){
                                intentos = 4;
                                Console.WriteLine("Su nip es valida, Bienvenido : " + usuario1.NombreTitular);
                                Console.WriteLine("--------------------------------------------------------------");
                                do{
                                    Console.WriteLine("------------MENÚ-------------");
                                    Console.WriteLine("1.- Consultar saldo");
                                    Console.WriteLine("2.- Depositar efectivo");
                                    Console.WriteLine("3.- Retirar efectivo");
                                    Console.WriteLine("4.- Transferir entre cuentas");
                                    Console.WriteLine("5.- Cambiar NIP");
                                    Console.WriteLine("6.- Cerrar sesión");
                                    if (int.TryParse(Console.ReadLine(), out opc3)){
                                        Console.WriteLine("-------------------------------------");
                                        switch(opc3){
                                            case 1:
                                                Console.WriteLine("Consultar saldo");
                                                Console.WriteLine("TU SALDO ACTUAL ES DE: $" + usuario1.SaldoCuenta);
                                                Console.WriteLine("---------------------------------------------------------");
                                                break;
                                            case 2:
                                                Console.WriteLine("Depositar efectivo");
                                                Console.WriteLine("Cuánto dinero quieres depositar?");
                                                if (double.TryParse(Console.ReadLine(), out deposito)&& deposito > 0){
                                                    usuario1.depositar(deposito);
                                                    Console.WriteLine("DEPOSITO EXITOSO!!!");
                                                    Console.WriteLine("------------------------------------------------------");
                                                }else{
                                                    Console.WriteLine("CANTIDAD INCORRECTA");
                                                    Console.WriteLine("------------------------------------------------------");
                                                }

                                                break;
                                            case 3:
                                                Console.WriteLine("Retirar efectivo");
                                                Console.WriteLine("Cuánto dinero quieres retirar?");
                                                if (double.TryParse(Console.ReadLine(), out retiro)&& retiro > 0){
                                                    usuario1.retirar(retiro);
                                                    Console.WriteLine("SALDO ACTUAL: $"+ usuario1.SaldoCuenta);
                                                    Console.WriteLine("RETIRO EXITOSO!!!");
                                                    Console.WriteLine("------------------------------------------------------");                                   
                                                }else{
                                                    Console.WriteLine("CANTIDAD INCORRECTA");
                                                    Console.WriteLine("------------------------------------------------------");
                                                }
                                                break;
                                            case 4:
                                                Console.WriteLine("Transferir entre cuenta");
                                                user = 1;
                                                Console.WriteLine("Cuánto dinero quieres transferir a la cuenta de: "+ usuario2.NombreTitular+ " con numero de cuenta: "+ usuario2.NumeroCuenta + " ?");
                                                if (double.TryParse(Console.ReadLine(), out transferencia)&& transferencia > 0){
                                                    usuario1.transferir(transferencia, usuario1, usuario2,  user);
                                                    Console.WriteLine("------------------------------------------------------");
                                                    
                                                }else{
                                                    Console.WriteLine("CANTIDAD INCORRECTA");
                                                    Console.WriteLine("------------------------------------------------------");
                                                }
                                                break;
                                            case 5:
                                                Console.WriteLine("Cambiar NIP");
                                                Console.WriteLine("Ingrese su nuevo NIP: ");
                                                newNip = Console.ReadLine();
                                                if (string.IsNullOrWhiteSpace(newNip)) {
                                                    Console.WriteLine("El nip no puede estar vacío");
                                                    Console.WriteLine("------------------------------------------------------");
                                                    return; 
                                                }else{
                                                    Console.WriteLine("Está seguro decambiar su NIP? 1.- SI   2.- NO");
                                                    // int respN = Console.ReadLine();
                                                    if (int.TryParse(Console.ReadLine(), out int respN)){
                                                        if (respN == 1){
                                                            usuario1.Nip = newNip;
                                                            Console.WriteLine("SE HA CAMBIADO EL NIP EXITOSAMENTE");
                                                            Console.WriteLine("------------------------------------------------------");
                                                        }else if(respN == 2){
                                                            usuario1.Nip = usuario1.Nip;
                                                            Console.WriteLine("NO SE HA CAMBIADO EL NIP");
                                                            Console.WriteLine("------------------------------------------------------");
                                                        }else{
                                                            Console.WriteLine("OPCION INVALIDA");
                                                            Console.WriteLine("------------------------------------------------------");
                                                        }
                                                    }else{
                                                        Console.WriteLine("NUMERO NO VALIDO");
                                                        Console.WriteLine("------------------------------------------------------");
                                                    }                                                    
                                                }                                                
                                                break;
                                            case 6:
                                                Console.WriteLine("SESIÓN CERRADA, VUELVA PRONTO.");
                                                Console.WriteLine("------------------------------------------------------");
                                                break;
                                            default:
                                                Console.WriteLine("OPCIÓN ERRONEA!!");
                                                Console.WriteLine("------------------------------------------------------");
                                                break;
                                        }
                                    }else{
                                        Console.WriteLine("Opcion invalida");
                                        Console.WriteLine("------------------------------------------------------");
                                    }
                                }while(opc3 != 6);

                            }else{
                                Console.WriteLine("No se pudo validar su nip para la cuenta: " + usuario1.NumeroCuenta);
                                Console.WriteLine("NIP incorrecto. Le quedan " + (2 - intentos) + " intentos.");
                                intentos++;
                                Console.WriteLine("----------------------------------------------------------------------------------");
                            }
                        }while(intentos < 3);
                        intentos =0;
                        break;
                    case 2:
                        do{
                            Console.WriteLine("para validar su identidad ingrese su nip: ");
                            validNip = Console.ReadLine();
                            Console.WriteLine("--------------------------------------------------------");
                            if(validNip.Equals(usuario2.Nip)){
                                intentos = 4;
                                Console.WriteLine("Su nip es valida, Bienvenido : " + usuario2.NombreTitular);
                                Console.WriteLine("--------------------------------------------------------");
                                do{
                                    Console.WriteLine("----------------MENÚ-----------------");
                                    Console.WriteLine("1.- Consultar saldo");
                                    Console.WriteLine("2.- Depositar efectivo");
                                    Console.WriteLine("3.- Retirar efectivo");
                                    Console.WriteLine("4.- Transferir entre cuentas");
                                    Console.WriteLine("5.- Cambiar NIP");
                                    Console.WriteLine("6.- Cerrar sesión");
                                    if (int.TryParse(Console.ReadLine(), out opc3)){
                                        Console.WriteLine("--------------------------------------------------------");
                                        switch(opc3){
                                            case 1:
                                                Console.WriteLine("Consultar saldo");
                                                Console.WriteLine("TU SALDO ACTUAL ES DE: $" + usuario2.SaldoCuenta);
                                                Console.WriteLine("--------------------------------------------------------");
                                                break;
                                            case 2:
                                                Console.WriteLine("Depositar efectivo");
                                                Console.WriteLine("Cuánto dinero quieres depositar?");
                                                if (double.TryParse(Console.ReadLine(), out deposito)&& deposito > 0){                                                    
                                                    usuario2.depositar(deposito);
                                                    Console.WriteLine("DEPOSITO EXITOSO!!!");
                                                    Console.WriteLine("--------------------------------------------------------");
                                                }else{
                                                    Console.WriteLine("CANTIDAD INCORRECTA");
                                                    Console.WriteLine("--------------------------------------------------------");
                                                }
                                                break;
                                            case 3:
                                                Console.WriteLine("Retirar efectivo");
                                                Console.WriteLine("Cuánto dinero quieres retirar?");
                                                if (double.TryParse(Console.ReadLine(), out retiro)&& retiro > 0){                                                    
                                                    usuario2.retirar(retiro);
                                                    Console.WriteLine("SALDO ACTUAL: $"+ usuario2.SaldoCuenta);
                                                     Console.WriteLine("RETIRO EXITOSO!!!");
                                                    Console.WriteLine("--------------------------------------------------------");
                                                }else{
                                                    Console.WriteLine("CANTIDAD INCORRECTA");
                                                    Console.WriteLine("--------------------------------------------------------");
                                                }
                                                break;
                                            case 4:
                                                Console.WriteLine("Transferir entre cuenta");
                                                user = 2;
                                                Console.WriteLine("Cuánto dinero quieres transferir a la cuenta de: "+ usuario2.NombreTitular+ " con numero de cuenta: "+ usuario2.NumeroCuenta + " ?");
                                                if (double.TryParse(Console.ReadLine(), out transferencia)&& transferencia > 0){
                                                    usuario2.transferir(transferencia, usuario1, usuario2,  user);
                                                    Console.WriteLine("--------------------------------------------------------");
                                                    
                                                }else{
                                                    Console.WriteLine("CANTIDAD INCORRECTA");
                                                    Console.WriteLine("--------------------------------------------------------");
                                                }
                                                break;
                                            case 5:
                                                Console.WriteLine("Cambiar NIP");
                                                Console.WriteLine("Ingrese su nuevo NIP: ");
                                                newNip = Console.ReadLine();
                                                if (string.IsNullOrWhiteSpace(newNip)) {
                                                    Console.WriteLine("El nip no puede estar vacío");
                                                    Console.WriteLine("--------------------------------------------------------");
                                                    return; 
                                                }else{
                                                    Console.WriteLine("Está seguro decambiar su NIP? 1.- SI   2.- NO");                                                    
                                                    if (int.TryParse(Console.ReadLine(), out int respN)){
                                                        if (respN == 1){
                                                            usuario2.Nip = newNip;
                                                            Console.WriteLine("SE HA CAMBIADO EL NIP EXITOSAMENTE");
                                                            Console.WriteLine("--------------------------------------------------------");
                                                        }else if(respN == 2){
                                                            usuario2.Nip = usuario2.Nip;
                                                            Console.WriteLine("NO SE HA CAMBIADO EL NIP");
                                                            Console.WriteLine("--------------------------------------------------------");
                                                        }else{
                                                            Console.WriteLine("OPCION INVALIDA");
                                                            Console.WriteLine("--------------------------------------------------------");
                                                        }
                                                    }else{
                                                        Console.WriteLine("NUMERO NO VALIDO");
                                                        Console.WriteLine("--------------------------------------------------------");
                                                    }                                                    
                                                }                                                
                                                break;
                                            case 6:
                                                Console.WriteLine("SESIÓN CERRADA, VUELVA PRONTO.");
                                                Console.WriteLine("------------------------------------------------------");
                                                break;
                                            default:
                                                Console.WriteLine("OPCIÓN ERRONEA!!");
                                                Console.WriteLine("------------------------------------------------------");
                                                break;
                                        }
                                    }else{
                                        Console.WriteLine("Opcion invalido");
                                        Console.WriteLine("------------------------------------------------------");
                                    }
                                }while(opc3 != 6);

                            }else{
                                Console.WriteLine("No se pudo validar su nip para la cuenta: " + usuario2.NumeroCuenta);
                                Console.WriteLine("NIP incorrecto. Le quedan " + (2 - intentos) + " intentos.");
                                intentos++;
                                Console.WriteLine("------------------------------------------------------");
                            }
                        }while(intentos < 3);
                        intentos =0;
                        break;
                    case 3:
                        Console.WriteLine("HA SALIDO DEL CAJERO, HASTA LUEGO!!!");
                        Console.WriteLine("------------------------------------------------------");
                        break;
                    default:
                        Console.WriteLine("opción invalida");
                        Console.WriteLine("------------------------------------------------------");
                        break;
                }
            }else{
                Console.WriteLine("Opción invalida");
                Console.WriteLine("------------------------------------------------------");
            }

        }while(opc2 != 3);
        
        
    }
    
    static string  aleatorio(){
            string numeroCuenta="";
            Random ran = new Random();

            int n1 = ran.Next(1,9);
            int n2 = ran.Next(1,9);
            int n3 = ran.Next(1, 9);
            int n4 = ran.Next(1, 9);
            int n5 = ran.Next(1, 9);
            int n6 = ran.Next(1, 9);
            int n7 = ran.Next(1, 9);
            int n8 = ran.Next(1, 9);

            numeroCuenta= "" +n1+n2+n3+n4+n5+n6+n7+n8;
            // Console.WriteLine(numeroCuenta);
            return numeroCuenta;
    }
}
