import { Response } from "PosApi/Create/RequestHandlers";

/**
 * The response for the SendEmailRequest.
 */
export default class SendEmailResponse extends Response {
    public dateSent: Date;
}