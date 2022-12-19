<?php

namespace App\Http\Controllers;

use App\Models\Phonebook;
use Illuminate\Http\Request;
use Illuminate\Http\Requestold;

class MainController extends Controller
{
    public function index() {
        $users = Phonebook::orderBy('updated_at', 'desc')->paginate(10);
        $header = 'Телефонный справочник';
        $s1 = '';
        $email = '';
        return view('phonebook', compact('users','header', 's1', 'email'));
    }

    public function search(Request $request) {
        $s1 = $request->s1;
        $email = $request->email;
        $header = 'Телефонный справочник';
        $users = Phonebook::where('name', 'LIKE', "%{$s1}%")->where('email', 'LIKE', "%{$email}%")->orderby('updated_at', 'desc')->paginate(10);
        return view('phonebook', compact('users','header', 's1', 'email'));
    }

    public function addphone(Request $request) {
        $name_old = $request->old('name');
        $email_old = $request->old('email');
        $phone_old = $request->old('phone');

        $valid = $request->validate([
            'email' => 'required|min:4|max:40',
            'name' => 'required|min:2|max:40',
            'phone' => 'required|min:4|max:20'
        ]);

        $ph = new Phonebook();
        $ph->name = $request->name;
        $ph->email = $request->email;
        $ph->phone = $request->phone;
        $ph->save();

        return redirect()->route('addphonebook')->with('message', 'Запись добавлена');
        //dd($request);
    }

    public function removephone(Request $request) {
        $id = $request->id;
        $deleted = Phonebook::where('id', '=', $id) -> delete();
        $users = Phonebook::orderBy('updated_at', 'desc')->paginate(10);
        $header = 'Телефонный справочник';
        $s1 = '';
        $email = '';
        return view('phonebook', compact('users','header', 's1', 'email'));
    }
}
