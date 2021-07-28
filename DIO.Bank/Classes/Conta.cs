using System;

namespace DIO.Bank
{
    public class Conta
    {   
        private TipoConta TipoConta{get;set;}

        public double Saldo { get; set; }

        public double Credito { get; set; }
        private string Nome{get;set;}



        public Conta(TipoConta tipoConta, double saldo,double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Credito = credito;
            this.Nome = nome;
            this.Saldo = saldo;
        }

        public bool Sacar(double valorSaque)
        {
            if(this.Saldo - valorSaque < (this.Credito * -1)){
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }
            else{
                this.Saldo -= valorSaque;
                Console.WriteLine("O saldo atual da conta de {0} é {1}", this.Nome,this.Saldo);
                return true;
            }
        }


        public void Depositar(double valorDeposito){
            this.Saldo += valorDeposito;
            Console.WriteLine("O saldo atual da conta de {0} é {1}", this.Nome,this.Saldo);
        }

        public void Transferir(double valorTransferencia,Conta contaDestino){
            if(this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno +="TipoConta" + this.TipoConta + " | ";
            retorno +="Nome" + this.Nome + " | ";
            retorno +="Saldo" + this.Saldo + " | ";
            retorno +="Credito" + this.Credito + " | ";
            return retorno;
        }


    }
}