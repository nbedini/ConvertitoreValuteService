using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService" nel codice e nel file di configurazione contemporaneamente.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string GetData(int value);

	// TODO: aggiungere qui le operazioni del servizio
}