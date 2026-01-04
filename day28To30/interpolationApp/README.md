❓ *ngIf vs CSS display:none

*ngIf DOM se element hata deta hai, jabki CSS sirf hide karta hai.

❓ Ek element pe 2 * kyun nahi?

Kyunki * internally <ng-template> me convert hota hai — ek element me ek hi template.

❓ Multiple condition chahiye?

Use:

<ng-container *ngIf="condition">
