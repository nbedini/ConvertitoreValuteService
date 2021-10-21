using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service" nel codice, nel file svc e nel file di configurazione contemporaneamente.
public class Service : IService
{
    public List<Valuta> valute = new List<Valuta>();

    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public List<Valuta> GetValute()
    {
        valute.Add(new Valuta("EUR", "Euro", 1));
        valute.Add(new Valuta("USD", "Dollaro Americano", 1.1655));
        valute.Add(new Valuta("GBP", "Sterlina Inglese", 0.8427));
        valute.Add(new Valuta("JPY", "Yen Giapponese", 133.12));
        valute.Add(new Valuta("CHF", "Franco Svizzero", 1.0710));
        valute.Add(new Valuta("CAD", "Dollaro Canadese", 1.4357));
        valute.Add(new Valuta("AUD", "Dollaro Australiano", 1.5495));
        valute.Add(new Valuta("BTC", "Bitcoin", 0.000017));

        return valute;
    }
}
