﻿using BankingSite.Model.DomainEntities;

namespace BankingSite.Model.ExternalComponentGateways
{
    public class BankMainframeGateway : IBankMainframeGateway
    {
        public int CreateNew(CreditCardApplication application)
        {
            // Simulation of interacting with external system
            return 9999999;
        }
    }
}