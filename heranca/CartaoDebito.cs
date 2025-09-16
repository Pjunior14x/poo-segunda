public class CartaoDebito
{

    public CartaoDebito()
    {
        Bandeira = "Visa";
        Bandeira = "MinhaBandeira";
        Bandeira = BandeiraCartao.Mastercard;

    }
    public string Numero { get; set; }
    public BandeiraCartao Bandeira { get; set; }

    public DateTime Vencimento { get; set; }

    public string Portador { get; set; }

    public string Cvv { get; set; }

    public bool Debitar(decimal valor)
    {
        if (valor > Saldo)
            return false;
    }


    public bool Debitar(decimal valor, bool usarLimite)
 if(UsarLimite){
    if (usarLimite)
 }
 
}

public enum BandeiraCartao
{

Visa,
Mastercard,
Amex,
Elo

}