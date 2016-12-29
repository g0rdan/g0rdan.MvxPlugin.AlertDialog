using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IAlertDialog
    {
		void Alert();
		Task AlertAsync();

		bool Confirm();
		Task<bool> ConfirAsync();

		void Input();
		Task InputAsync();
    }
}
