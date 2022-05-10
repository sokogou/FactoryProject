﻿using FactoryProject.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Services
{
    class SupplyOfferService
    {

        public static SupplyOffer[] SupplyOffers()
        {
            Random rand = new Random();
            SupplyOffer[] offers = new SupplyOffer[3];
            for (int i = 0; i < 3; i++)
            {
                offers[i] = new SupplyOffer(rand.Next(4500, 5000), rand.Next(1, 4), (RowMatterialQuality)rand.Next(1, 4));
            }
            return offers;
        }


        //public SupplyOffer BestOffer()
        //{
        //    SupplyOffer bestOffer = new SupplyOffer();
            
        //    return bestOffer;
        //}
        

        // public SupplyOffer[] Offers { get; set; }
        //public SupplyOffer[] offers = new SupplyOffer[3];
        //public SupplyOfferService()
        //{
        //    Offers = new SupplyOffer[3];
        //}

        //public static SupplyOffer[] SupplyOffers()
        //{
        //    Random rand = new Random();
        //    SupplyOffer[] offers = new SupplyOffer[3];
        //    for (int i = 0; i < 3; i++)
        //    {
        //        offers[i] = new SupplyOffer(rand.Next(4500, 5000), rand.Next(1, 3), (RowMatterialQuality)rand.Next(1, 4));
        //    }
        //    return offers;
        //}
    }
}
