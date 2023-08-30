
import { ExtensionRequestBase } from "PosApi/Create/RequestHandlers";
import SendEmailResponse from "./SendEmailResponse";

/**
 * The controller for SimpleNextView.
 */
export default class SendEmailRequest<TResponse extends SendEmailResponse> extends ExtensionRequestBase<TResponse> {
    public emailAddress: string;
    public message: string;
}