
import { IProductSearchColumn } from "PosApi/Extend/Views/SearchView";
import { ICustomColumnsContext } from "PosApi/Extend/Views/CustomListColumns";
import { CurrencyFormatter } from "PosApi/Consume/Formatters";
import { ProxyEntities } from "PosApi/Entities";

export default (context: ICustomColumnsContext): IProductSearchColumn[] => {
    return [
        {
            title: "ProductId_CUSTOMIZED",
            computeValue: (row: ProxyEntities.ProductSearchResult): string => { return row.ItemId; },
            ratio: 20,
            collapseOrder: 3,
            minWidth: 120
        }, 
        {
            title: "Name",
            computeValue: (row: ProxyEntities.ProductSearchResult): string => { return row.Name; },
            ratio: 40,
            collapseOrder: 2,
            minWidth: 200
        }, {
            title: "Custom",
            computeValue: (row: ProxyEntities.ProductSearchResult): string => { return "RecID: " + row.RecordId; },
            ratio: 20,
            collapseOrder: 4,
            minWidth: 200
        }, {
            title: "Price",
            computeValue: (row: ProxyEntities.ProductSearchResult): string => { return CurrencyFormatter.toCurrency(row.Price); },
            ratio: 20,
            collapseOrder: 1,
            minWidth: 100,
            isRightAligned: true
        }
    ];
};