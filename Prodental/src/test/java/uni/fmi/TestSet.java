package uni.fmi;

import static org.junit.Assert.assertEquals;

import java.util.HashSet;
import java.util.Set;

import org.junit.Test;

import uni.fmi.models.Role;

public class TestSet {
	
	@Test
	public void testSetWithStrings() {
		final Set<String> testInstance = new HashSet<String>();
		String value1 = "value";
		testInstance.add(value1);
		String value2 = "value";
		testInstance.add(value2);
		String value3 = "value";
		testInstance.add(value3);
		assertEquals(2,testInstance.size());
		
	}
	
	
	@Test
	public void testSetWithRoles() {
		
		final Set<Role> testInstance = new HashSet<Role>();
		Role value1 = new Role();
		value1.setRole("Dentist");
		testInstance.add(value1);
		Role value2 = new Role();
		value2.setRole("Recetionist");
		testInstance.add(value2);
		Role value3 = new Role();
		value3.setRole("User");
		testInstance.add(value3);
		assertEquals(2, testInstance.size());
		
	}

}
