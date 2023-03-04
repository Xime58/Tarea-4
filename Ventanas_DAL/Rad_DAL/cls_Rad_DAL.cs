using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanas_DAL.Rad_DAL
{
	public class cls_Rad_DAL
	{
		private decimal _dclnumLimite, _dclresultadoSumatoria, _dclrPar, _dclrImpar;

		public decimal dclnumLimite { get => _dclnumLimite; set => _dclnumLimite = value; }
		public decimal dclresultadoSumatoria { get => _dclresultadoSumatoria; set => _dclresultadoSumatoria = value; }
		public decimal dclrPar { get => _dclrPar; set => _dclrPar = value; }
		public decimal dclrImpar { get => _dclrImpar; set => _dclrImpar = value; }
	}
}
