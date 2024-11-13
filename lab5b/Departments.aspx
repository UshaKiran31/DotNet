<%@ Page Title="Departments" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Departments.aspx.cs" Inherits="lab5b.Departments" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Departments Page Content -->
    <div class="container mt-4">
        <div class="card">
            <div class="card-body">
                <h2 class="display-4">Departments at VVIT</h2>
                <p class="lead">
                    Vasireddy Venkatadri Institute of Technology (VVIT) offers a variety of undergraduate and postgraduate programs. Here are the departments:
                </p>

                <h3>Undergraduate Programs (B.Tech)</h3>
                <ul>
                    <li><strong>Civil Engineering (CE)</strong> - Focuses on sustainable infrastructure.</li>
                    <li><strong>Electrical and Electronics Engineering (EEE)</strong> - Covers power generation and distribution.</li>
                    <li><strong>Mechanical Engineering (ME)</strong> - Involves design and manufacturing.</li>
                    <li><strong>Electronics and Communication Engineering (ECE)</strong> - Specializes in telecommunications.</li>
                    <li><strong>Computer Science and Engineering (CSE)</strong> - Emphasizes programming and algorithms.</li>
                    <li><strong>Information Technology (IT)</strong> - Focuses on data management and cybersecurity.</li>
                    <!-- Add additional departments here -->
                </ul>

                <h3>Postgraduate Programs (M.Tech)</h3>
                <ul>
                    <li><strong>Computer Science and Engineering (CSE)</strong></li>
                    <li><strong>VLSI and Embedded Systems (VLSI&ES)</strong></li>
                    <li><strong>Power Electronics and Electric Drives (PEED)</strong></li>
                    <li><strong>Machine Design (MD)</strong></li>
                    <li><strong>Software Engineering (SE)</strong></li>
                    <!-- Add additional programs here -->
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
