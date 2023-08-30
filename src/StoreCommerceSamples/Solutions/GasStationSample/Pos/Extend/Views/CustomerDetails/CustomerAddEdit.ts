import {
    CustomerAddEditCustomControlBase,
    ICustomerAddEditCustomControlState,
    ICustomerAddEditCustomControlContext
} from "PosApi/Extend/Views/CustomerAddEditView";


export default class CustomerAddEdit extends CustomerAddEditCustomControlBase {   
    constructor(id: string, context: ICustomerAddEditCustomControlContext) {
        super(id, context);
       
    }

    /**
     * Binds the control to the specified element.
     * @param {HTMLElement} element The element to which the control should be bound.
     */
    public onReady(element: HTMLElement): void {        
        document.getElementById("marketingOptInToggle_PrimaryPhone").style.display = "none";
        document.getElementById("marketingOptInToggle_PrimaryEmail").style.display = "none";
    }

    /**
     * Initializes the control.
     * @param {ICustomerDetailCustomControlState} state The initial state of the page used to initialize the control.
     */
    public init(state: ICustomerAddEditCustomControlState): void {
        
        
    }

       
}