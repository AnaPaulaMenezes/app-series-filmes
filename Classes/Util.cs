using System;
namespace DIO.Catalogo
{
    public static class Util
    {
        public static void validaGenero(int genero)
        {

            if (!Enum.IsDefined(typeof(Genero), genero))
            {
                throw new ArgumentException("Gênero não encontrado!");
            }


        }
    }
}