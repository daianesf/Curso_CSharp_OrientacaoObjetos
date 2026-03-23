using System.Text.RegularExpressions;
using InterfaceAluguelCarros.Entities;

namespace InterfaceAluguelCarros.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}