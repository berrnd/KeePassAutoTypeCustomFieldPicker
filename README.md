KeePassAutoTypeCustomFieldPicker
================================

Pick custom fields in an Auto-Type sequence (similar to `{PICKCHARS}`)

Purpose
-------
On some sites, particularly banking related sites, there are login forms where you have to enter "The answer for security question 3 out of 5".
In KeePass, you probably have stored these answers in custom fields.

With the current `{PICKCHARS}` placeholder you can pick single chars out of a field.
But for this use case you need a placeholder for a complete field value.

To fix the time to when this will be implemented in KeePass itself, I have created this plugin.

Usage
-----
Just use the new placeholder `{PICKCUSTOMFIELD}` in an Auto-Type sequence.
When you execute such a sequence, a window will popup and let you choose a custom field (just like `{PICKCHARS}` does).
The value of the picked custom field will be replaced in the Auto-Type sequence.

Installation
-------------
Just download the AutoTypeCustomFieldPicker.plgx file (see files above or [click here](https://github.com/berrnd/KeePassAutoTypeCustomFieldPicker/raw/master/AutoTypeCustomFieldPicker.plgx)), copy it to the KeePass application directory and restart KeePass.

Limitions
---------
- If you use `{PICKCUSTOMFIELD}` more than once in an Auto-Type sequence, the picker will only popup once und all placeholders will be replaced with the same value of the selected custom field (something like `{PICKCHARS:Password:ID=1}` is currently not implemented).

####Warning
This is a "quick & dirty" implementation.
But it works and will not harm your KeePass database or something like that.
But anyways, use it at your own risk (I use it too ;)).

####Licence
GPL v3 or later