using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanas_DAL.Timer_DAL
{
	public class cls_Timer_DAL
	{
		private int _itiempo, _iminutos,_isegundos, _imilisegundos;

		public int itiempo { get => _itiempo; set => _itiempo = value; }
		public int iminutos { get => _iminutos; set => _iminutos = value; }
		public int isegundos { get => _isegundos; set => _isegundos = value; }
		public int imilisegundos { get => _imilisegundos; set => _imilisegundos = value; }
	}
}
