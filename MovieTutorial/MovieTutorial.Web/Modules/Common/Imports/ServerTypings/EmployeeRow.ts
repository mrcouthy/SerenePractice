
namespace MovieTutorial {
    export interface EmployeeRow {
        EmployeeId?: number;
        Name?: string;
        Address?: number;
        Email?: string;
    }

    export namespace EmployeeRow {
        export const idProperty = 'EmployeeId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Employee';

        export namespace Fields {
            export declare const EmployeeId;
            export declare const Name;
            export declare const Address;
            export declare const Email;
        }

        ['EmployeeId', 'Name', 'Address', 'Email'].forEach(x => (<any>Fields)[x] = x);
    }
}

