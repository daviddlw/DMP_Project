using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP_Project
{
    public interface IDmpBiz<TParam, TResult>
    {
        List<TResult> GetList(TParam parameters);
    }
}
