using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventanas_DAL.Ecua_DAL;
using Ventanas_BLL.Ecual_BLL;


namespace Ventanas_BLL.Ecual_BLL
{
	public class cls_Ecua_BLL
	{
		public void CalcularEcuacion(ref cls_Ecua_DAL Obj_Ecua_DAL)
		{

			Obj_Ecua_DAL.dbldiscriminante = Math.Pow(Obj_Ecua_DAL.dblnumB, 2) - 4 * Obj_Ecua_DAL.dblnumA * Obj_Ecua_DAL.dblnumC;
			if (Obj_Ecua_DAL.dbldiscriminante == 0)
			{
				Obj_Ecua_DAL.dblsolucion1 = -Obj_Ecua_DAL.dblnumB / (2 * Obj_Ecua_DAL.dblnumA);
			}

			if (Obj_Ecua_DAL.dbldiscriminante > 0)
			{
				Obj_Ecua_DAL.dblsolucion1 = (-Obj_Ecua_DAL.dblnumB + Math.Sqrt(Obj_Ecua_DAL.dbldiscriminante)) / (2 * Obj_Ecua_DAL.dblnumA);
				Obj_Ecua_DAL.dblsolucion2 = (-Obj_Ecua_DAL.dblnumB - Math.Sqrt(Obj_Ecua_DAL.dbldiscriminante)) / (2 * Obj_Ecua_DAL.dblnumA);
			}

		}

	}
}
