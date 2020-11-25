using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTDAL
{
    public class Repository
    {
        bench3Entities ent = new bench3Entities();
        //login dataretriving detset 

        public bool Login(yt obj)
        {
            //find where add remove 
            yt ob=new yt();
            foreach(var v in ent.yts)
            {
                if (v.name == obj.name)
                {
                    ob = v;
                }
            }
            if(ob.name.Equals(obj.name) &&ob.roll == obj.roll)
            return true;
            
            return false;
        }

        //public bool (yt obj)
        //{
        //    find where add remove
        //    var ob = ent.yts.Where(i => (i.name == obj.name && i.roll == obj.roll));
        //    if (ob != null)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

}
}
