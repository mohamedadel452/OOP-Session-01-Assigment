<div dir="rtl">

# 💻 البرمجة كائنية التوجه — المحاضرة 01: الـ Struct، التغليف، الخصائص، والـ Indexers (نظام Smart Delivery)
### OOP Session 01: Structs, Constructor Overloading, Encapsulation, Properties & Indexers (Smart Delivery)

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Module](https://img.shields.io/badge/Module-02_OOP-0284c7?style=for-the-badge)](#)
[![Interactive Guide](https://img.shields.io/badge/%F0%9F%8C%90_Live_Study_Guide-HTML_Interactive-8b5cf6?style=for-the-badge)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-01-Assigment/blob/master/Study_Guide/OOP_Session01_Deep_Dive.html)

> **نبذة عن المشروع:** 🚀 [02 OOP - Session 01] Smart Delivery System Foundation: Value Type Structs, Constructor Overloading, Property Validation, Calculated Properties & Multi-Parameter Indexers + Deep Dive HTML Guide.

---

## 🌐 الدليل التفاعلي المشروح بالـ HTML (Interactive Study Guide)

تم تضمين الدليل التفاعلي المشروح بالكامل داخل مجلد [`Study_Guide/`](./Study_Guide) في هذا المستودع، ويمكنك قراءته مباشرة في المتصفح عبر الروابط التالية:

- 🌐 دليل الغوص العميق التفاعلي: OOP Session 01 (HTML): **[🌐 معاينة حية في المتصفح (Live Preview)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-01-Assigment/blob/master/Study_Guide/OOP_Session01_Deep_Dive.html)** | **[📄 فتح ملف الـ HTML في المستودع](./Study_Guide/OOP_Session01_Deep_Dive.html)**
- 📂 **[فتح مجلد المحاضرة المحلي الكامل في `nots` (للتصفح المحلي على الجهاز)](../../../../nots/02_OOP/Session_01_Struct_Encapsulation_&_Properties)**

---

### 🧠 الملاحظات الهندسية والمفاهيم المعمارية (Engineering Notes)
1. **دلالات النسخ بالقيمة في الـ `Struct` (`Copy-by-Value Semantics`):**
   - تم تصميم `DeliveryAddress` كـ `struct` لأنه يمثل قيمة مترابطة صغيرة (`Value Object`). عند نسخ متغير `struct`، يتم إنشاء نسخة مستقلة تماماً على الـ `Stack`، وتعديل النسخة لا يؤثر مطلقاً على الأصل.
2. **التغليف الحقيقي وحماية قواعد العمل (`Encapsulation & Data Invariants`):**
   - في `Shipment`، تم إخفاء الحقول الخاصة (`trackingCode`, `weight`, `deliveryFee`) وتوفير بوابات محمية عبر **Properties**:
     - رفض الأوزان أو الرسوم السالبة (`if (value > 0)`).
     - جعل `TrackingCode` و `DeliveryFee` للقراءة فقط من الخارج (`private set`).
     - بناء خاصية محسوبة ديناميكياً (`EstimatedCost => DeliveryFee + (decimal)(Weight * 5)`).
3. **تعدد الـ Indexers (`Indexer Overloading`) في `DeliveryCenter`:**
   - توفير واجهة وصول مزدوجة للمركز:
     - **Integer Indexer (`center[0]`):** للوصول السريع للشحنة عبر رقم الفهرس مع حماية الحدود.
     - **String Indexer (`center["TRK-101"]`):** للبحث المباشر عن الشحنة باستخدام كود التتبع.

---

## 🗂️ هيكلة الكود والتمارين التطبيقية المحلولة

| الجزء | المكون المعماري | التفاصيل المطبقة في الكود |
| :--- | :--- | :--- |
| **Part 01** | Theoretical Questions (Q1 & Q2) | مقارنة سلوك النسخ بين `Struct` (Stack Value Copy) و `Class` (Heap Reference Copy) ومشاكل الحقول العامة. |
| **Part 02.1** | `DeliveryAddress` Struct | تمثيل عنوان التوصيل (`City`, `Street`, `BuildingNumber`) ودالة `GetFullAddress()`. |
| **Part 02.2** | `Shipment` Struct & Encapsulation | تطبيق Constructor Overloading، خصائص محمية بشروط تحقق، وخاصية محسوبة `EstimatedCost`. |
| **Part 02.3** | `DeliveryCenter` & Overloaded Indexers | إدارة مصفوفة الشحنات بتهيئة كسولة (Lazy Init) وتوفير `this[int index]` و `this[string trackingCode]`. |
| **Part 06** | Full Interactive Console App | بناء سيناريو تشغيل كامل لإضافة الشحنات والبحث عنها وتحديث رسوم التوصيل. |

---

## 🧭 خريطة مسار هندسة `.NET` الكامل على GitHub

| # | المرحلة (Module) | المستودع (Repository) | الموضوع الرئيسي | الدليل التفاعلي (Live HTML) |
| :---: | :--- | :--- | :--- | :---: |
| **01** | `01_CSharp_Basics` | **[`CSharp-Basics02-Assigment`](https://github.com/mohamedadel452/CSharp-Basics02-Assigment)** | أنواع البيانات، نموذج الكائنات (System.Object)، والتحويلات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics02-Assigment/blob/master/Study_Guide/CSharp_Basics_Session02_Guide.html) |
| **02** | `01_CSharp_Basics` | **[`CSharp-Basics03-Assigment`](https://github.com/mohamedadel452/CSharp-Basics03-Assigment)** | معمارية النصوص (Strings & StringBuilder)، جمل التحكم، والحلقات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics03-Assigment/blob/master/Study_Guide/CSharp_Basics_Session03_Guide.html) |
| **03** | `01_CSharp_Basics` | **[`CSharp-Basics04-Assigment`](https://github.com/mohamedadel452/CSharp-Basics04-Assigment)** | المصفوفات (1D & 2D Arrays) وتمرير المعاملات للدوال (Value / ref / out / params) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics04-Assigment/blob/master/Study_Guide/CSharp_Basics_Session04_Guide.html) |
| **04** | `01_CSharp_Basics` | **[`CSharp-Basics05-Assigment`](https://github.com/mohamedadel452/CSharp-Basics05-Assigment)** | محددات الوصول (Access Modifiers)، التغليف، والـ Enums | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics05-Assigment/blob/master/Study_Guide/CSharp_Basics_Session05_Guide.html) |
| **05** | `02_OOP` | **[`OOP-Session-01-Assigment`](https://github.com/mohamedadel452/OOP-Session-01-Assigment)** | الـ Struct، التغليف، الخصائص، والـ Indexers (نظام Smart Delivery) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-01-Assigment/blob/master/Study_Guide/OOP_Session01_Deep_Dive.html) |
| **06** | `02_OOP` | **[`OOP-Session-02-Assigment`](https://github.com/mohamedadel452/OOP-Session-02-Assigment)** | الفئات (Classes)، الوراثة، وتسلسل الـ Constructors (Smart Delivery Part 1) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-02-Assigment/blob/master/Study_Guide/OOP_Session02_Deep_Dive.html) |
| **07** | `02_OOP` | **[`OOP-Session-03-Assigment`](https://github.com/mohamedadel452/OOP-Session-03-Assigment)** | تعدد الأشكال (Polymorphism)، الربط الديناميكي، والكلاسات المختومة (Sealed) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-03-Assigment/blob/master/Study_Guide/OOP_Session03_04_Dispatch_&_SOLID_Deep_Dive.html) |
| **08** | `02_OOP` | **[`OOP-Session-04-Assigment`](https://github.com/mohamedadel452/OOP-Session-04-Assigment)** | التجريد (Abstraction)، الفئات المجردة، والواجهات (Smart Delivery Part 3) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-04-Assigment/blob/master/Study_Guide/OOP_Session04_Deep_Dive.html) |
| **09** | `02_OOP` | **[`OOP-Session-05-Assigment`](https://github.com/mohamedadel452/OOP-Session-05-Assigment)** | نسخ الكائنات، Static، دوال التوسيع، والـ Partial Classes (Smart Delivery Final) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-05-Assigment/blob/master/Study_Guide/OOP_Session05_Deep_Dive.html) |
| **10** | `03_Advanced_CSharp` | **[`Advanced-CSharp-01`](https://github.com/mohamedadel452/Advanced-CSharp-01)** | الأنواع المعممة (Generics)، القيود (Constraints)، والـ Variance | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-01/blob/master/Study_Guide/Generics_Deep_Part1_Core.html) |
| **11** | `03_Advanced_CSharp` | **[`Advanced-CSharp-02`](https://github.com/mohamedadel452/Advanced-CSharp-02)** | المفوضات (Delegates)، تعبيرات Lambda، ونظام ShopMaster | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-02/blob/master/Study_Guide/Delegates_Part1_Core.html) |
| **12** | `03_Advanced_CSharp` | **[`Advanced-CSharp-03`](https://github.com/mohamedadel452/Advanced-CSharp-03)** | معمارية هياكل البيانات والـ Collections (6 أنظمة تطبيقية) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part1-collections-list.html) |
| **13** | `04_Database` | **[`Database-Session-01-Assigment`](https://github.com/mohamedadel452/Database-Session-01-Assigment)** | تصميم قواعد البيانات، مخططات الـ ERD، والتحويل العلائقي (Relational Mapping) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Database-Session-01-Assigment/blob/master/Study_Guide/ERD_Part1_Design_Intro.html) |

---

## 🚀 طريقة التشغيل المحلي (How to Run)

```bash
git clone https://github.com/mohamedadel452/OOP-Session-01-Assigment.git
cd OOP-Session-01-Assigment
dotnet run --project "C#-Basics06-Assigment/C#-Basics06-Assigment.csproj"
```

**إعداد وتطوير:** [محمد عادل محمد بيومي (mohamedadel452)](https://github.com/mohamedadel452) — كلية الحاسبات والمعلومات، جامعة عين شمس.

</div>
