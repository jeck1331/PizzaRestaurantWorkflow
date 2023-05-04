using Pizzeria.Models.Enums;

namespace Pizzeria.Services;

public class StateConvertor
{
    public static string ProductState(ProductState productState)
    {
        switch (productState)
        {
            case Models.Enums.ProductState.Accept:
                return "Принят";
            case Models.Enums.ProductState.GettingReady:
                return "Готовится";
            case Models.Enums.ProductState.NotAccept:
                return "Не принят";
            case Models.Enums.ProductState.Canceled:
                return "Отменен";
            case Models.Enums.ProductState.Completed:
                return "Приготовлен";
            case Models.Enums.ProductState.Delivered:
                return "Доставляется";
            case Models.Enums.ProductState.Failed:
                return "Не удачно";
            case Models.Enums.ProductState.Terminated:
                return "Просрочен";
            case Models.Enums.ProductState.Ready:
                return "Готов";
            default:
                return "";
        }
    }
    public static string CourierState(CourierState courierState)
    {
        switch (courierState)
        {
            case Models.Enums.CourierState.Accept:
                return "Принят";
            case Models.Enums.CourierState.Free:
                return "Свободен";
            case Models.Enums.CourierState.Canceled:
                return "Отменил";
            case Models.Enums.CourierState.Done:
                return "Доставил";
            case Models.Enums.CourierState.OnProcess:
                return "Доставляет";
            case Models.Enums.CourierState.Terminated:
                return "Просрочен";
            default:
                return "";
        }
    } 
}