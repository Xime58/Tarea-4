using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanas_DAL.Ecua_DAL
{
	public class cls_Ecua_DAL
	{
		private double _dblnumA, _dblnumB, _dblnumC, _dbldiscriminante, _dblsolucion1, _dblsolucion2;

		public double dblnumA { get => _dblnumA; set => _dblnumA = value; }
		public double dblnumB { get => _dblnumB; set => _dblnumB = value; }
		public double dblnumC { get => _dblnumC; set => _dblnumC = value; }
		public double dbldiscriminante { get => _dbldiscriminante; set => _dbldiscriminante = value; }
		public double dblsolucion1 { get => _dblsolucion1; set => _dblsolucion1 = value; }
		public double dblsolucion2 { get => _dblsolucion2; set => _dblsolucion2 = value; }
	}
}
