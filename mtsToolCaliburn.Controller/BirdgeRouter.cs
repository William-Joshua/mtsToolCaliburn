using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolCaliburn.Controller
{
    /// <summary>
    /// 数据路由
    /// </summary>
    public class BirdgeRouter
    {        
        /// <summary>
             /// 桥接抽象层
             /// </summary>
        public static BirdgeRouterController BirdgeRouterController { get; private set; }

        public BirdgeRouter(BirdgeRouteAddress birdgeRouteAddress)
        {
            switch(birdgeRouteAddress)
            {
                case BirdgeRouteAddress._mts_api_client: BirdgeRouterController = new MtsapiRouterController();  break;
                case BirdgeRouteAddress._k3_api_client: BirdgeRouterController = new K3apiRouterController(); break;
                case BirdgeRouteAddress._oa_api_client: BirdgeRouterController = new OaapiRouterController(); break;
                case BirdgeRouteAddress._local_wcf_client: BirdgeRouterController = new WcflocalRouterController(); break;
                default: BirdgeRouterController = new MtsapiRouterController(); break;
            }
    }
    }

    /// <summary>
    /// 数据桥接路由类型
    /// </summary>
    public enum BirdgeRouteAddress
    {
        _mts_api_client, // MTS Web API
        _k3_api_client,  // K3 Web API
        _oa_api_client, // OA Web API
        _local_wcf_client  // localhost WCF
    }
}
