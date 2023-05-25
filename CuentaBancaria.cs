using System;



public class CuentaBancaria{
        
        private string? nombreTitular;
        public string? NombreTitular{
            get {return nombreTitular;}
            set {nombreTitular= value;}
        }

        private double saldoCuenta;
        public double SaldoCuenta{
            get{return saldoCuenta;}
            set{saldoCuenta = value;}
        }

        private string? numeroCuenta;
        public string? NumeroCuenta{
            get {return numeroCuenta;}
            set {numeroCuenta= value;}
        }

        private string? nip;
        public string? Nip{
            get{return nip;}
            set{nip=value;}
        }

        public CuentaBancaria (string nombreTitular, double saldoCuenta, string nip){
            this.nombreTitular = nombreTitular;
            this.saldoCuenta = saldoCuenta;
            this.nip = nip;
        }

        public CuentaBancaria(){

        }

        public double depositar(double deposito){

            saldoCuenta = saldoCuenta + deposito;
            
            return 0;
        }

        public double retirar(double retiro){
            double saldoRestante=0;
            if(retiro> saldoCuenta){
                Console.WriteLine("Saldo insuficiente para realizar esta acción");
            }else{
                saldoCuenta =  saldoCuenta - retiro; 
            }
            return 0;
        }

        public double transferir(double tranferencia,CuentaBancaria usuario1, CuentaBancaria usuario2, int user){
            
            if (user == 1 && tranferencia <= usuario1.saldoCuenta ){
                usuario1.saldoCuenta = usuario1.saldoCuenta - tranferencia;
                usuario2.saldoCuenta = usuario2.saldoCuenta + tranferencia;
                Console.WriteLine("Transferencia exitosa");
            }else if (user == 2 && tranferencia <= usuario2.saldoCuenta){
                usuario2.saldoCuenta = usuario2.saldoCuenta - tranferencia;
                usuario1.saldoCuenta = usuario1.saldoCuenta + tranferencia;
                Console.WriteLine("Transferencia exitosa");
            }else{
                Console.WriteLine("Transferencia rechazada, saldo insuficiente");
            }
            
            return 0;
        }
        
        
}
