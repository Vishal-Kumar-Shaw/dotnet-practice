Component kya hota hai?
Ans -  Component is the building blocks of an App. By combining all the components. Like an app consist of Header, footer and all.
Component is the smallest reusable UI unit in Angular that controls a part of the view with its own logic and template.
Better tree-shaking, simpler dependency graph, easier lazy loading, reduced boilerplate.

Standalone component kyu introduce hua?
Ans - for cleaner code, less complex, No modules or more boiler plate, independent component

2️⃣ Standalone Component kyu introduce hua? (REAL reason)

Tumne jo bola ✔️ sahi, ab deep reason samajh:

❌ Old problem (NgModule era)

Har component ko:

declarations me daalo

imports me dependency

Lazy loading complex

Boilerplate zyada

Testing heavy

✅ Standalone ka goal

Angular team ne bola:

“Component ko self-sufficient bana do”

Matlab:

Component khud batayega:

mujhe kya import chahiye

mujhe module nahi chahiye

Company project me migration kaise karoge?

Ans - one by one making component standalone true and removing declaration from module, whole app cant be migrated at once