| Code | Name                            | Description                                  |
|------|---------------------------------|----------------------------------------------|
| 100  | Continue                        | The server has received the request headers, and the client should proceed to send the request body. |
| 101  | Switching Protocols             | The requester has asked the server to switch protocols. |
| 200  | OK                              | The request was successful.                  |
| 201  | Created                         | The request has been fulfilled, and a new resource is created. |
| 202  | Accepted                        | The request has been accepted for processing, but the processing has not been completed. |
| 203  | Non-Authoritative Information   | The returned meta-information in the entity-header is not the definitive set as available from the origin server. |
| 204  | No Content                      | The server successfully processed the request but is not returning any content. |
| 205  | Reset Content                   | The server successfully processed the request, but there is no content to send in the response. |
| 206  | Partial Content                 | The server is delivering only part of the resource due to a range header sent by the client. |
| 300  | Multiple Choices                | The requested resource corresponds to any one of a set of representations, each with its own specific location. |
| 301  | Moved Permanently               | The requested resource has been assigned a new permanent URI and any future references to this resource should use one of the returned URIs. |
| 302  | Found                           | The requested resource resides temporarily under a different URI. |
| 303  | See Other                       | The response to the request can be found under a different URI and should be retrieved using a GET method on that resource. |
| 304  | Not Modified                    | The resource has not been modified since the last requested time. |
| 305  | Use Proxy                       | The requested resource must be accessed through the proxy given by the Location field. |
| 307  | Temporary Redirect              | The requested resource resides temporarily under a different URI. The temporary URI should be given in the response. |
| 400  | Bad Request                     | The request could not be understood by the server due to malformed syntax. |
| 401  | Unauthorized                    | The request requires user authentication.      |
| 402  | Payment Required                | This code is reserved for future use.         |
| 403  | Forbidden                       | The server understood the request, but it refuses to authorize it. |
| 404  | Not Found                       | The server has not found anything matching the Request-URI. |
| 405  | Method Not Allowed               | The method specified in the Request-Line is not allowed for the resource identified by the Request-URI. |
| 406  | Not Acceptable                  | The resource identified by the request is only capable of generating response entities that have content characteristics not acceptable according to the accept headers sent in the request. |
| 407  | Proxy Authentication Required   | This code is similar to 401 (Unauthorized), but indicates that the client must first authenticate itself with the proxy. |
| 408  | Request Timeout                 | The client did not produce a request within the time that the server was prepared to wait. |
| 409  | Conflict                        | The request could not be completed due to a conflict with the current state of the target resource. |
| 410  | Gone                            | The requested resource is no longer available at the server and no forwarding address is known. |
| 411  | Length Required                 | The server refuses to accept the request without a defined Content-Length. |
| 412  | Precondition Failed             | The precondition given in one or more of the request-header fields evaluated to false when it was tested on the server. |
| 413  | Payload Too Large               | The server is refusing to process a request because the request payload is larger than the server is willing or able to process. |
| 414  | URI Too Long                    | The server is refusing to service the request because the request-target is longer than the server is willing to interpret. |
| 415  | Unsupported Media Type          | The server is refusing to service the request because the entity of the request is in a format not supported by the requested resource for the requested method. |
| 416  | Range Not Satisfiable           | None of the ranges in the Range request-header field overlap the current extent of the selected resource. |
| 417  | Expectation Failed              | The expectation given in the request's Expect header field could not be met by at least one of the inbound servers. |
| 418  | I'm a teapot                    | This code was defined in 1998 as one of the traditional IETF April Fools' jokes. |
| 421  | Misdirected Request             | The request was directed at a server that is not able to produce a response. |
| 422  | Unprocessable Entity            | The server understands the content type of the request entity, and the syntax of the request entity is correct, but it was unable to process the contained instructions. |
| 423  | Locked                          | The source or destination resource of a method is locked. |
| 424  | Failed Dependency               | The method could not be performed on the resource because the requested action depended on another action and that action failed. |
| 425  | Too Early                       | The server is unwilling to risk processing a request that might be replayed. |
| 426  | Upgrade Required                | The client should switch to a different protocol. |
| 428  | Precondition Required           | The origin server requires the request to be conditional. |
| 429  | Too Many Requests               | The user has sent too many requests in a given amount of time. |
| 431  | Request Header Fields Too Large | The server is unwilling to process the request because its header fields are too large. |
| 451  | Unavailable For Legal Reasons   | A server operator has received a legal demand to deny access to a resource or to a set of resources that includes the requested resource. |
| 500  | Internal Server Error           | The server encountered an unexpected condition that prevented it from fulfilling the request. |
| 501  | Not Implemented                 | The server does not support the functionality required to fulfill the request. |
| 502  | Bad Gateway                     | The server, while acting as a gateway or proxy, received an invalid response from the upstream server it accessed in attempting to fulfill the request. |
| 503  | Service Unavailable             | The server is currently unable to handle the request due to temporary overloading or maintenance of the server. |
| 504  | Gateway Timeout                 | The server, while acting as a gateway or proxy, did not receive a timely response from the upstream server or some other auxiliary server it needed to access in order to complete the request. |
| 505  | HTTP Version Not Supported       | The server does not support, or refuses to support, the major version of HTTP that was used in the request message. |
| 506  | Variant Also Negotiates         | Transparent content negotiation for the request results in a |
| 507  | Insufficient Storage            | The server is unable to store the representation needed to complete the request. |
| 508  | Loop Detected                   | The server detected an infinite loop while processing a request. |
| 510  | Not Extended                    | Further extensions to the request are required for the server to fulfill it. |
| 511  | Network Authentication Required | The client needs to authenticate to gain network access. |
