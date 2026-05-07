using Ex022.Interfaces;

namespace Ex022.Models;

public abstract class ClassBase: IAnalizaNome
{
   public string NomeCompleto { get; private set; }

   public ClassBase(string nomeCompleto)
   {
      NomeCompleto = nomeCompleto;
   }


   public abstract void NomeAnaliza();
   
}