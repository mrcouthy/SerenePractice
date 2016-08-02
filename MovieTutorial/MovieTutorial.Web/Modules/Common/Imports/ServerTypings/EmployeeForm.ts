

namespace MovieTutorial {
    export class EmployeeForm extends Serenity.PrefixedContext {
        static formKey = 'Employee';
    }

    export interface EmployeeForm {
        Name: Serenity.StringEditor;
        Address: Serenity.IntegerEditor;
        Email: Serenity.StringEditor;
    }

    [['Name', () => Serenity.StringEditor], ['Address', () => Serenity.IntegerEditor], ['Email', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(EmployeeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}