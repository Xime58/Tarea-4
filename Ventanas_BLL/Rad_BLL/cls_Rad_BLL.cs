using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventanas_DAL.Rad_DAL;

namespace Ventanas_BLL.Rad_BLL
{
	public class cls_Rad_BLL
	{
		public void SumarRaddionButton(ref cls_Rad_DAL Obj_Rad_DAL)
		{
			if (Obj_Rad_DAL.dclnumLimite >= 0)
			{
				Obj_Rad_DAL.dclresultadoSumatoria = (Obj_Rad_DAL.dclnumLimite * (Obj_Rad_DAL.dclnumLimite + 1)) / 2;
			}
			else
			{
				if (Obj_Rad_DAL.dclnumLimite < 0)
				{
					Obj_Rad_DAL.dclresultadoSumatoria = (Obj_Rad_DAL.dclnumLimite * (-Obj_Rad_DAL.dclnumLimite + 1)) / 2;
				}
			}

			if (Obj_Rad_DAL.dclnumLimite >= 0)
			{
				
				for (int i = 2; i <= Obj_Rad_DAL.dclnumLimite; i+= 2)
				{
					Obj_Rad_DAL.dclrPar = Obj_Rad_DAL.dclrPar + i;
				}

				for (int i = 1; i <= Obj_Rad_DAL.dclnumLimite; i += 2)
				{
					Obj_Rad_DAL.dclrImpar = Obj_Rad_DAL.dclrImpar + i;
				}

			}
			if (Obj_Rad_DAL.dclnumLimite < 0)
			{

				for (int i = -2; i >= Obj_Rad_DAL.dclnumLimite; i += -2)
				{
					Obj_Rad_DAL.dclrPar = Obj_Rad_DAL.dclrPar + i;
				}

				for (int i = -1; i >= Obj_Rad_DAL.dclnumLimite; i += -2)
				{
					Obj_Rad_DAL.dclrImpar = Obj_Rad_DAL.dclrImpar + i;
				}
			}

		}


	}
}
