package uni.fmi.calendar;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class CalendarBookingService {
	
	public static final Pattern VALID_EMAIL_ADDRESS_REGEX = 
		    Pattern.compile("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$", Pattern.CASE_INSENSITIVE);

	private static List<LocalDateTime> dateDb = new ArrayList<LocalDateTime>();
	private static boolean isAvailable = true;
	
	
 
	public static String bookHour(String date, String hour, String email) {
		dateDb.clear();
		fillDate();
		if(date == null ||hour == null) {
			return "Неуспешно запазен час!";
		}
		
		if(email == null || email.isEmpty() || !validateEmail(email)) {
			return "Въведете валиден имейл!";
		}
		
		String datehour = date+" "+hour;
		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm"); 
		LocalDateTime wantedDateTime = LocalDateTime.parse(datehour, formatter);
		for(int i = 0; i<dateDb.size();i++) {
			if(dateDb.get(i).getYear() == wantedDateTime.getYear() && dateDb.get(i).getMonth() == wantedDateTime.getMonth()
					&&dateDb.get(i).getDayOfMonth() == wantedDateTime.getDayOfMonth()&&dateDb.get(i).getHour() == wantedDateTime.getHour()
					&&dateDb.get(i).getMinute() == wantedDateTime.getMinute()) {
				isAvailable = false;
			}
		}
 
		if(wantedDateTime.getYear()>2100) {
			return"Невалидни дата и час!";
		}
		
		
		if(isAvailable) {
			return "Успешно запазихте час!";
		}else {
			return "Часът е зает!";
		}
 
  }
 
	public static void fillDate() {
	   LocalDateTime ld1 = LocalDateTime.of(2022, 2, 10, 11, 11);
	   LocalDateTime ld2 = LocalDateTime.of(2022, 3, 9, 13, 30);
	   LocalDateTime ld3 = LocalDateTime.of(2022, 5, 22, 15, 15);
	   dateDb.add(ld1);
	   dateDb.add(ld2);
	   dateDb.add(ld3);
	}
	
	public static boolean validateEmail(final String emailStr) {
        java.util.regex.Matcher matcher = VALID_EMAIL_ADDRESS_REGEX.matcher(emailStr);
        return matcher.find();
   }
	
	
}
