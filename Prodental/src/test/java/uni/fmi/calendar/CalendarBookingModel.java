package uni.fmi.calendar;


import java.time.LocalDateTime;


public class CalendarBookingModel {

	private String email;
	private String message;
	private String date;
	private String hour;

	public void setEmail(final String email) {
		this.email=email;
		
	}
	
	
	public void setDate(String date) {
		this.date = date;
	}

	public void clickReserveBtn() {
		
		message = CalendarBookingService.bookHour(date,hour,email);
	}

	public String getMessage() {
		return message;
	}


	public void setHour(String string) {
		this.hour = string;
	}



	
	
	
}
