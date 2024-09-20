using NewTalents;
using Xunit;

namespace TesteNewTalents
{
	public class UnitTest1
	{
		[Theory]
		[InlineData (1, 2, 3)]
		[InlineData (4, 5, 9)]
		public void Test1(int val1, int val2, int resultado)
		{
			Calculadora calc = new Calculadora();

			int resultadoCalculadora = calc.somar(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}
	}
}