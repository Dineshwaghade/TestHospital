var selectedRow = null

function onFormSubmit() {
    var formData = readFormData();
    if (validate())
    {

    if (selectedRow==null)
    {
        insertNewRecord(formData);
    }
    else
    {
        updateRecord(formData);
    }
    resetForm();
    document.getElementById("onsubmit1").setAttribute("data-dismiss", "modal")
    }
    else
    {
        document.getElementById("onsubmit1").removeAttribute("data-dismiss")
    }

}

function readFormData() {
    var formData = {};
    formData["TestName"] = document.getElementById("TestName").value;
    formData["TestDate"] = document.getElementById("TestDate").value;
    formData["TestPrice"] = document.getElementById("TestPrice").value;
    formData["TestResult"] = document.getElementById("TestResult").value;
    formData["DoctorRemarks"] = document.getElementById("DoctorRemarks").value;
    return formData;
}

function insertNewRecord(data) {
    var table = document.getElementById("patientList").getElementsByTagName('tbody')[0];
    var newRow = table.insertRow(table.length);
    cell1 = newRow.insertCell(0);
    cell1.innerHTML = data.TestName;
    cell2 = newRow.insertCell(1);
    cell2.innerHTML = data.TestDate;
    cell3 = newRow.insertCell(2);
    cell3.innerHTML = data.TestPrice;
    cell4 = newRow.insertCell(3);
    cell4.innerHTML = data.TestResult;
    cell5 = newRow.insertCell(4);
    cell5.innerHTML = data.DoctorRemarks;
    console.log(cell5.innerHTML);
    cell6 = newRow.insertCell(5);
    cell6.innerHTML = `<a onClick="onEdit(this)" data-toggle="modal" data-target="#exampleModal" class="btn btn-info">Edit</a> 
        <a onClick="onDelete(this)" class ="btn btn-danger"> Delete </a>`;
    var tamt=document.getElementById('totalamt').value;
    tamt = parseFloat(tamt) + parseFloat(data.TestPrice);
    document.getElementById('totalamt').value = tamt;
    console.log(tamt);
    
  }

function resetForm() {
    document.getElementById("TestName").value="";
    document.getElementById("TestDate").value="";
    document.getElementById("TestPrice").value="";
    document.getElementById("TestResult").value="";
    document.getElementById("DoctorRemarks").value = "";
    selectedRow = null;
}

function onEdit(td) {
    selectedRow = td.parentElement.parentElement;
    document.getElementById("TestName").value = selectedRow.cells[0].innerHTML;
    document.getElementById("TestDate").value = selectedRow.cells[1].innerHTML;
    document.getElementById("TestPrice").value = selectedRow.cells[2].innerHTML;
    document.getElementById("TestResult").value = selectedRow.cells[3].innerHTML;
    document.getElementById("DoctorRemarks").value = selectedRow.cells[4].innerHTML;

}
function updateRecord(formData) {
    selectedRow.cells[0].innerHTML=formData.TestName;
    selectedRow.cells[1].innerHTML = formData.TestDate;
    selectedRow.cells[2].innerHTML = formData.TestPrice;
    selectedRow.cells[3].innerHTML = formData.TestResult;
    selectedRow.cells[4].innerHTML = formData.DoctorRemarks;
}

function onDelete(td) {
    if (confirm('Are you sure to delete this record?')) {
        row = td.parentElement.parentElement;
        document.getElementById("patientList").deleteRow(row.rowIndex);
        resetForm();
    }
}
function validate() {
    isValid = true;
    if (document.getElementById("TestName").value == "") {
        isValid = false;
        document.getElementById("TestNameValidationError").classList.remove("d-none");
    }
    else {
        isvalid = true;
        if (!document.getElementById("TestNameValidationError").classList.contains("d-none"))
            document.getElementById("TestNameValidationError").classList.add("d-none");
    }
    if (document.getElementById("TestDate").value == "") {
        isValid = false;
        document.getElementById("TestDateValidationError").classList.remove("d-none");
    }
    else {
        isvalid = true;
        if (!document.getElementById("TestDateValidationError").classList.contains("d-none"))
            document.getElementById("TestDateValidationError").classList.add("d-none");
    }
    if (document.getElementById("TestPrice").value == "") {
        isValid = false;
        document.getElementById("TestPriceValidationError").classList.remove("d-none");
    }
    else {
        isvalid = true;
        if (!document.getElementById("TestPriceValidationError").classList.contains("d-none"))
            document.getElementById("TestPriceValidationError").classList.add("d-none");
    }
    if (document.getElementById("TestResult").value == "") {
        isValid = false;
        document.getElementById("TestResultValidationError").classList.remove("d-none");
    }
    else {
        isvalid = true;
        if (!document.getElementById("TestResultValidationError").classList.contains("d-none"))
            document.getElementById("TestResultValidationError").classList.add("d-none");
    }
    if (document.getElementById("DoctorRemarks").value == "") {
        isValid = false;
        document.getElementById("DoctorRemarksValidationError").classList.remove("d-none");
    }
    else {
        isvalid = true;
        if (!document.getElementById("DoctorRemarksValidationError").classList.contains("d-none"))
            document.getElementById("DoctorRemarksValidationError").classList.add("d-none");
    }
    return isValid;
}