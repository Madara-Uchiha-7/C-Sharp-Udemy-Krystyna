///
/// Even though the struct is better to be immutbale, sometime we need to update them.
/// We discussed this issue in the end of the 262 lecture.
/// Operations that would modify a struct object should actually create a new object.
/// We call it a non-destructive mutation.
/// The original object remains unchanged and a new object is created.
/// So, to find the date after one week, we should not modify the days property from DateTime type.
/// Instead we should call AddDays method, which creates another DateTime object.
///


DateTime dateTime = new DateTime(2023, 6, 7);
DateTime daysAfterWeek = dateTime.AddDays(7);

Console.ReadKey();